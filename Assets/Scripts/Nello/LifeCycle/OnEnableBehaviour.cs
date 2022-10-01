using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnEnableBehaviour : ActionBase {
    void OnEnable() {
        action.Invoke();
    }
}
