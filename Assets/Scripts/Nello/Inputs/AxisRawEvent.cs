using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AxisRawEvent : ActionFloatBase {
    public KeyCode negative = KeyCode.S;
    public KeyCode positive = KeyCode.Z;
    void Update() {
        action.Invoke( (Input.GetKey(negative) ? -1 : 0) + (Input.GetKey(positive) ? 1 : 0) );
    }
}
