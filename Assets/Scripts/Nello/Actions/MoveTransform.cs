using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTransform : MonoBehaviour {
    public Space space;
    public bool useDeltaTime = true;
    public void TranslateY(float units) {
        if(useDeltaTime) units *= Time.deltaTime;
        transform.Translate(Vector3.up * units, space);
    }
    public void TranslateX(float units) {
        if(useDeltaTime) units *= Time.deltaTime;
        transform.Translate(Vector3.right * units, space);
    }
    public void TranslateZ(float units) {
        if(useDeltaTime) units *= Time.deltaTime;
        transform.Translate(Vector3.forward * units, space);
    }
}
