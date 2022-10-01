using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DelayedEvent : ActionBase {
    public float delayInSeconds = .1f;
    public void SetDelay(float delay) { this.delayInSeconds = delay; }
    public void CallDelayed() {
        if(delayInSeconds <= 0) {
            action.Invoke();
        } else {
            StartCoroutine(DelayedCoroutine(delayInSeconds));
        }
    }

    IEnumerator DelayedCoroutine(float delay) {
        yield return new WaitForSeconds(delay);
        action.Invoke();
    }
}
