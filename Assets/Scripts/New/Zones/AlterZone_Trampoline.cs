using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlterZone_Trampoline : AlterZone
{
    public float force = 100;

    public override void OnEnter(RigidbodyController controller)
    {
        controller.collider.material = zoneType.physicMaterial;
        // controller.body.AddForce(force * transform.up, ForceMode.Impulse);
        // controller.body.velocity = Vector3.Reflect(controller.body.velocity, transform.up);
        controller.body.velocity = force * transform.up * controller.body.velocity.magnitude;
    }

    public override void WhileStay(RigidbodyController controller)
    {
        controller.body.AddForce(zoneType.windForce);
    }
}
