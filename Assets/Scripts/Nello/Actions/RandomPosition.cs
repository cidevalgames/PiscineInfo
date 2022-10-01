using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomPosition : MonoBehaviour
{
    public Vector3 min, max;
    public bool linear = false;
    public void SetDefault() {
        transform.localPosition = Vector3.zero;
    }
    public void SetPosition(Vector3 pos) {
        transform.localPosition = pos;
    }
    public void SetRandom() {
        if(linear) transform.localPosition = Vector3.Lerp(min, max, Random.value);
        else transform.localPosition = new Vector3( Random.Range(min.x, max.x), Random.Range(min.y, max.y), Random.Range(min.z, max.z));
    }
}
