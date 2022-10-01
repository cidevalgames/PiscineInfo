using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FixedUpdateBehaviour : ActionBase {
    public void SetFixedFrameTime(float value) {
        Time.fixedDeltaTime = value;
    }
    void FixedUpdate() {
        action.Invoke();
    }
}
