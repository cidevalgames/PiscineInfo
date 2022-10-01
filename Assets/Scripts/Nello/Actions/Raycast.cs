using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Raycast : MonoBehaviour {
    public LayerMask layers = -1;
    public float distance = 1;
    public Vector3 localVector = Vector3.forward;


    public UnityEngine.Events.UnityEvent<PosDirPair> HitAction;
    public float hitDirectionMultiplier = 1;
    public UnityEngine.Events.UnityEvent<PosRotPair> HitNormalAction;
    public float debugTime = 0;
    public bool triggerObjectsEvent = false;
    public bool callHitWithMaxDistWhenFail = true;

    public void SetHitDirectionMultiplier(float mult) {
        hitDirectionMultiplier = mult;
    }

    void LateUpdate() {
        DoRaycast();
    }
    public void DoRaycast() {
        Vector3 v = transform.forward;

        if(debugTime > 0) Debug.DrawRay(transform.position, v * distance, Color.red, debugTime);

        RaycastHit rch;
        if(Physics.Raycast(transform.position, v, out rch, distance, layers)) {
            if(debugTime > 0) Debug.Log("hit :" + rch.collider.name);

            RaycastHitObject o = rch.collider.GetComponent<RaycastHitObject>();

            PosDirPair dirPair = new PosDirPair(rch.point, hitDirectionMultiplier * v);

            HitAction.Invoke(dirPair);
            if(triggerObjectsEvent && o) o.HitAction.Invoke(dirPair);

            PosRotPair pair = new PosRotPair(rch.point, Quaternion.LookRotation(rch.normal));

            HitNormalAction.Invoke(pair);
            if(triggerObjectsEvent && o) o.HitNormalAction.Invoke(pair);
        } else if(callHitWithMaxDistWhenFail) {
            PosDirPair dirPair = new PosDirPair(rch.point, hitDirectionMultiplier * v);
            HitAction.Invoke(dirPair);

            PosRotPair pair = new PosRotPair(transform.position, Quaternion.LookRotation(-v));
            HitNormalAction.Invoke(pair);
        }
    }
}
