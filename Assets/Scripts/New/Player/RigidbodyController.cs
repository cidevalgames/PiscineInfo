using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RigidbodyController : MonoBehaviour
{
    public Transform axisProvider; 
    public Rigidbody body;
    public float multiplier = 1;
    public string axisHorizontal = "Horizontal";
    public string axisVertical = "Vertical";

    public Vector3 movement = Vector3.zero;

    bool shouldJump;
    bool isGrounded;

    void Update() {
        if(isGrounded)
        {
            if(Input.GetButtonDown("Jump")) {
                shouldJump = true;
            }
        }
    }
    
    public Vector3 jumpForce;
    public ForceMode jumpForceMode;
    public float windForce = 5;

    void FixedUpdate()
    {
        // if(fowardMove != 0 || strafeMove != 0) {
            movement.x = Input.GetAxis(axisHorizontal) * multiplier;
            movement.z = Input.GetAxis(axisVertical) * multiplier;
            body.AddForce(axisProvider.rotation * movement);
        // }

        if(shouldJump && isGrounded) {
            body.AddForce(jumpForce, jumpForceMode);
            shouldJump = false;
            isGrounded = false;
        }
        
        // if(currentZone) body.AddForce(currentZone.zoneType.windForce);
        if(currentZone) currentZone.WhileStay(this);
    }
    
    // public ZoneVariables currentZoneType;
    public AlterZone currentZone;
    public ZoneVariables defaultZoneType;
    // public ZoneVariables[] zoneTypes;

    private void OnTriggerEnter(Collider other) {
        AlterZone zone = other.GetComponent<AlterZone>();
        GameObject colliderGameObject = other.gameObject;

        if(zone) {
            currentZone = zone;
            // currentZoneType = zone.zoneType;
            OnZoneChange();
        }

        if(colliderGameObject.layer == 6) isGrounded = true;
    }
    
    private void OnTriggerExit(Collider other) {
        AlterZone zone = other.GetComponent<AlterZone>();
        if(zone) {
            if(currentZone.zoneType.zoneType == zone.zoneType.zoneType) {
                currentZone = null;
                OnZoneChange();
            }
        }
    }

    public Collider collider;

    void OnZoneChange() {
        // if(currentZoneType == ZoneType.STANDARD) {
        // } else if(currentZoneType == ZoneType.ICE ) { }

        // switch(currentZoneType) {
        //     case ZoneType.STANDARD :
        //         collider.material = standardPhysicMaterial;
        //         break;
        //     case ZoneType.ICE :
        //         collider.material = icePhysicMaterial;
        //         break;
        // }

        if(currentZone) currentZone.OnEnter(this);
        else
        {
            collider.material = defaultZoneType.physicMaterial;
        }
    }
}
