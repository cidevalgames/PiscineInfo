using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CopyRot : MonoBehaviour {
    public Transform toCopy;
    public void SetTarget(Transform t) {
        toCopy = t;
    }
    void LateUpdate() {
        transform.rotation = toCopy.rotation;
    }
}
