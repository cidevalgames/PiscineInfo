using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomRotation : MonoBehaviour {
    [Tooltip("min / max in degrees")]
    public Vector3 min, max;
    public bool linear = false;
    public void SetDefault() {
        transform.localRotation = Quaternion.identity;
    }
    public void SetEulers(Vector3 eulers) {
        transform.localRotation = Quaternion.Euler(eulers);
    }
    public void SetRandom() {
        if(linear) transform.localRotation = Quaternion.Slerp(Quaternion.Euler(min), Quaternion.Euler(max), Random.value);
        else transform.localRotation = Quaternion.Euler(Random.Range(min.x, max.x), Random.Range(min.y, max.y), Random.Range(min.z, max.z));
    }
}
