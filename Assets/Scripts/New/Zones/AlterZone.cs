using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum ZoneType {
    STANDARD = 0,
    ICE = 1,
    WIND_UP,
    LADDER,
}


[System.Serializable]
public struct ZoneVariables {
    public ZoneType zoneType;
    public PhysicMaterial physicMaterial;
    public Vector3 windForce;
    public float climbSpeed;
}

public class AlterZone : MonoBehaviour
{
    // public ZoneType myZoneType; 
    public ZoneVariables zoneType;

    public virtual void OnEnter(RigidbodyController controller)
    {
        controller.collider.material = zoneType.physicMaterial;
    }

    public virtual void WhileStay(RigidbodyController controller)
    {
        controller.body.AddForce(zoneType.windForce);
    }
}
