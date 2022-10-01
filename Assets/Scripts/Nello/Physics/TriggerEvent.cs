using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerEvent : MonoBehaviour {
    public UnityEngine.Events.UnityEvent<PosRotPair> onEnter;
    public UnityEngine.Events.UnityEvent<PosRotPair> onExit;
    List<GameObject> insideObjects = new List<GameObject>();

    public string TagRestriction = "";

    void Start() {
        onExit.Invoke( new PosRotPair(transform.position, transform.rotation) );
    }

    private void OnTriggerEnter(Collider other) {
        if(!string.IsNullOrWhiteSpace(TagRestriction) && !other.gameObject.CompareTag(TagRestriction)) return;

        Vector3 fwd = other.transform.forward;
        fwd.y = 0;
        onEnter.Invoke( new PosRotPair(other.transform.position, Quaternion.LookRotation(fwd)) );

        if(!insideObjects.Contains(other.gameObject)) insideObjects.Add(other.gameObject);
    }
    
    private void OnTriggerExit(Collider other) {
        if(!string.IsNullOrWhiteSpace(TagRestriction) && !other.gameObject.CompareTag(TagRestriction)) return;

        if(insideObjects.Contains(other.gameObject)) insideObjects.Remove(other.gameObject);

        if(insideObjects.Count == 0)
        {
            Vector3 fwd = other.transform.forward;
            fwd.y = 0;
            onExit.Invoke( new PosRotPair(other.transform.position, Quaternion.LookRotation(fwd)) );
        }
    }
}
