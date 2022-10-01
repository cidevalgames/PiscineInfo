using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Distance : ActionFloatBase {
    public Transform distanceWith;
    public void SetTarget(Transform t) {
        distanceWith = t;
    }
    void LateUpdate() {
        action.Invoke( Vector3.Distance(transform.position, distanceWith.position) );
    }
}
