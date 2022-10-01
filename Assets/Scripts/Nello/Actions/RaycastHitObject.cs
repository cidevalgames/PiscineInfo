using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaycastHitObject : MonoBehaviour {
    public UnityEngine.Events.UnityEvent<PosDirPair> HitAction;
    public UnityEngine.Events.UnityEvent<PosRotPair> HitNormalAction;
    public void OnImpact(PosDirPair hit) {
        HitAction.Invoke(hit);
    }
    public void OnImpactNormal(PosRotPair hit) {
        HitNormalAction.Invoke(hit);
    }
}
