using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnDestroyBehaviour : ActionBase {
    void OnDestroy() {
        action.Invoke();
    }
}
