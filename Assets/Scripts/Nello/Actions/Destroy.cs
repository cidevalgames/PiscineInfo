using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour {
    public GameObject toDestroy;
    public void SetTarget(GameObject go) { toDestroy = go; }
    public void DoDestroy() {
        if(toDestroy) Destroy(toDestroy);
    }
}
