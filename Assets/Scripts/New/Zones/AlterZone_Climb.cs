using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlterZone_Climb : AlterZone
{
    public float force = 100;

    public override void OnEnter(RigidbodyController controller)
    {
        controller.collider.material = zoneType.physicMaterial;
    }

    public override void WhileStay(RigidbodyController controller)
    {
        if(Input.GetAxis("Vertical") > 0)
        {
            controller.body.AddForce(Vector3.up * Input.GetAxis("Vertical") * zoneType.climbSpeed);
        }
    }
}
