using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddForce : MonoBehaviour {
    public Rigidbody body;
    public bool localSpace;
    public ForceMode forceMode;
    public Vector3 force;
    public float multiplier = 1;
    public void AddForceToBody() {
        AddForceTo(body, force);
    }
    public void AddForceToBodyMuliplied(float f) {
        AddForceTo(body, force * f);
    }
    
    public void AddForceToMe(Vector3 force) {
        AddForceTo(body, force);
    }

    public void AddForceTo(Rigidbody body, Vector3 force) {
        if(localSpace) {
            body.AddForce(body.transform.rotation * force * multiplier);
        } else {
            body.AddForce(force * multiplier);
        }
    }
    
    public void AddImpactForce(PosDirPair impact) {
        Debug.DrawRay( impact.position, impact.direction * multiplier, Color.white, .3f );
        body.AddForceAtPosition(impact.direction * multiplier, impact.position, ForceMode.Impulse);
    }
}
