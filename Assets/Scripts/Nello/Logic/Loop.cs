using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loop : ActionBase {
    public int count = 1;
    public void SetCount(int count) { this.count = count; }
    public virtual void CallLoop() {
        for (int i = 0; i < count; i++)
            action.Invoke();
    }
}
