using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoopDelay : Loop {
    public float delayInSeconds = .1f;
    public void SetDelay(float delay) { this.delayInSeconds = delay; }
    public override void CallLoop() {
        if(delayInSeconds <= 0) {
            for (int i = 0; i < count; i++)
                action.Invoke();
        } else {
            StartCoroutine(LoopDelayCoroutine(delayInSeconds, count));
        }
    }

    IEnumerator LoopDelayCoroutine(float delay, int count) {
        for (int i = 0; i < count; i++) {
            action.Invoke();
            yield return new WaitForSeconds(delay);
        }
    }
}
