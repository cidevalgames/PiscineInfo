using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AwakeBehaviour : ActionBase {
    void Awake() {
        action.Invoke();
    }
}
