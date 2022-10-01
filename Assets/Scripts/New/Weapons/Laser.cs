using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser : MonoBehaviour
{
    public LayerMask layers = -1;
    public ForceMode mode;
    public float distance = 1;
    public float force = 5;

    void FixedUpdate()
    {
        Vector3 v = transform.forward;
        RaycastHit rch;

        // Defines if a mouse button is down
        bool isButtonDown = Input.GetButton("LaserPush") || Input.GetButton("LaserPull") || Input.GetAxis("LaserPush Controller") > 0 || Input.GetAxis("LaserPull Controller") > 0;
        float direction = 1;

        if(!isButtonDown) return;

        // Reverses the direction of the force if right click is down
        if(Input.GetButton("LaserPull") || Input.GetAxis("LaserPull Controller") > 0) direction = -1;

        // Tests a raycast from the position of the parent
        if(Physics.Raycast(transform.position, v, out rch, distance, layers)) {
            // Variable that contains the rigidbody of the hit object
            Rigidbody rayHitObject = rch.collider.GetComponent<Rigidbody>();

            if(rayHitObject != null)
            {
                // Add force to the object hit by the raycast
                rayHitObject.AddForceAtPosition(v * force * direction, rch.point, mode);
            }
        }
    }
}
