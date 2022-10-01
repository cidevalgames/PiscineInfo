using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaycastMyPath : MonoBehaviour {
    Vector3 lastPos;
    public LayerMask layers = -1;
    public UnityEngine.Events.UnityEvent<PosDirPair> HitAction;
    public float hitDirectionMultiplier = 1;
    public UnityEngine.Events.UnityEvent<PosRotPair> HitNormalAction;
    public float debugTime = 0;
    
    public bool triggerObjectsEvent = false;
    void OnEnable() {
        lastPos = transform.position;
    }
    void LateUpdate() {
        DoRaycast();
        lastPos = transform.position;
    }

    public void DoRaycast() {
        Vector3 v = transform.position - lastPos;
        float l = v.magnitude;

        if(debugTime > 0) Debug.DrawLine(transform.position, lastPos, Color.red, debugTime);

        RaycastHit rch;
        if(Physics.Raycast(lastPos, v, out rch, l, layers)) {

            RaycastHitObject o = rch.collider.GetComponent<RaycastHitObject>();
            PosDirPair dirPair = new PosDirPair(rch.point, hitDirectionMultiplier * (v/l));
            HitAction.Invoke(dirPair);
            if(triggerObjectsEvent && o) o.OnImpact(dirPair);

            PosRotPair rotPair = new PosRotPair(rch.point, Quaternion.LookRotation(rch.normal));

            HitNormalAction.Invoke(rotPair);
            if(triggerObjectsEvent && o) o.OnImpactNormal(rotPair);
            
            if(debugTime > 0) Debug.Log("hit :" + rch.collider.name + " > " + o);
        }
    }
}
