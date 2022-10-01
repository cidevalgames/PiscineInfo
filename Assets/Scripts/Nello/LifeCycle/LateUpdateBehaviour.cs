using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LateUpdateBehaviour : ActionBase {
    void LateUpdate() {
        action.Invoke();
    }
}
