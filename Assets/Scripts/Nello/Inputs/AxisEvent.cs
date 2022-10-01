using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AxisEvent : ActionFloatBase {
    public string axis = "Horizontal";

    void Update() {
        action.Invoke( Input.GetAxis(axis) );
    }
}
