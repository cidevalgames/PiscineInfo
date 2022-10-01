using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum mathEvent {
    Add,
    Substract,
    DeltaTimeMultiply,
    Multiply,
    ScreemHeightDivide,
    Divide,
    Min,
    Max,
    Modulo,
    Absolute,
    Sin,
    Cos,
}
[System.Serializable]
public struct mathRoad {
    public mathEvent math;
    public float value;
}
public class MathsEventRoad : ActionFloatBase {
    public mathRoad[] roadMaths;
    public void ApplyRoad(float baseValue) {
        foreach(var m in roadMaths) {
            switch(m.math) {
                case mathEvent.Add :
                    baseValue += m.value;
                    break;
                case mathEvent.Substract :
                    baseValue -= m.value;
                    break;
                case mathEvent.DeltaTimeMultiply :
                    baseValue *= m.value * Time.deltaTime;
                    break;
                case mathEvent.ScreemHeightDivide :
                    baseValue /= m.value * Screen.height;
                    break;
                case mathEvent.Multiply :
                    baseValue *= m.value;
                    break;
                case mathEvent.Divide :
                    baseValue /= m.value;
                    break;
                case mathEvent.Min :
                    baseValue = Mathf.Min(baseValue, m.value);
                    break;
                case mathEvent.Max :
                    baseValue = Mathf.Max(baseValue, m.value);
                    break;
                case mathEvent.Modulo :
                    baseValue = baseValue % m.value;
                    break;
                case mathEvent.Absolute :
                    baseValue = Mathf.Abs(baseValue);
                    break;
                case mathEvent.Sin :
                    baseValue = Mathf.Sin(baseValue);
                    break;
                case mathEvent.Cos :
                    baseValue = Mathf.Cos(baseValue);
                    break;

            }
        }
        action.Invoke(baseValue);
    }
}
