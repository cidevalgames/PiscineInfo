using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using NelowGames;

public class AxisMouseEvent : ActionFloatBase {
    public RectTransform.Axis axis;
    float mouse;
    void Update() {
        float m2 = 0;
        if(axis == RectTransform.Axis.Horizontal)
            m2 = Input.mousePosition.x / Screen.height;
        else
            m2 = Input.mousePosition.y / Screen.height;

        action.Invoke(m2 - mouse);
        mouse = m2;
    }
}