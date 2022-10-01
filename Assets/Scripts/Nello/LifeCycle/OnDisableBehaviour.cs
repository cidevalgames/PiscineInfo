using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnDisableBehaviour : ActionBase {
    void OnDisable() {
        action.Invoke();
    }
}
