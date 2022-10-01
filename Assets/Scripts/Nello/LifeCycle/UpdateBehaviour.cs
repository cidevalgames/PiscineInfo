using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpdateBehaviour : ActionBase {
    void Update() {
        action.Invoke();
    }
}
