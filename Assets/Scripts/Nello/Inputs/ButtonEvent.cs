using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonEvent : MonoBehaviour {
    public string button = "Fire0";
    public UnityEngine.Events.UnityEvent onDown, whileDown, onUp;
    public void Update() {
        if(Input.GetButtonDown(button)) onDown.Invoke();
        else if(Input.GetButtonUp(button)) onUp.Invoke();
        else if(Input.GetButton(button)) whileDown.Invoke();
    }
}
