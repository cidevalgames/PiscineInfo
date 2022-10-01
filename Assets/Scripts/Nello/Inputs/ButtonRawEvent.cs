using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonRawEvent : MonoBehaviour {
    public KeyCode key;
    public UnityEngine.Events.UnityEvent onDown, whileDown, onUp;
    public void Update() {
        if(Input.GetKeyDown(key)) onDown.Invoke();
        else if(Input.GetKeyUp(key)) onUp.Invoke();
        else if(Input.GetKey(key)) whileDown.Invoke();
    }
}
