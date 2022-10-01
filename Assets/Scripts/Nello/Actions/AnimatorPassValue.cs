using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatorPassValue : MonoBehaviour {
    public Animator animator;
    public string variableName;

    public void PassAsTrigger() {
        if(animator && !string.IsNullOrWhiteSpace(variableName))
            animator.SetTrigger(variableName);
    }
    public void PassAsBool(bool value) {
        if(animator && !string.IsNullOrWhiteSpace(variableName))
            animator.SetBool(variableName, value);
    }
    public void PassAsFloat(float value) {
        if(animator && !string.IsNullOrWhiteSpace(variableName))
            animator.SetFloat(variableName, value);
    }
}
