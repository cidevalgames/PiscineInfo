using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloatAccumulator : MonoBehaviour {
    public float value;
    public Vector2 clamp = new Vector2(0, 2);
    public float threshold = 1;
    public UnityEngine.Events.UnityEvent<float> belowThrehold, aboveThreshold;
    public void Add(float value) {
        this.value += value;
    }
    public void Sub(float value) {
        this.value -= value;
    }
    public void Mult(float value) {
        this.value *= value;
    }
    public void Divide(float value) {
        this.value /= value;
    }
    public void SetValue(float value) {
        this.value = value;
    }

    public void LateUpdate() {
        Check();
    }

    public void Check() {
        value = Mathf.Clamp(value, clamp.x, clamp.y);
        (value > threshold ? aboveThreshold : belowThrehold).Invoke(value   );
    }

}
