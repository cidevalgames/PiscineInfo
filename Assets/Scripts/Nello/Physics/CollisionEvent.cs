using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionEvent : MonoBehaviour {
    public UnityEngine.Events.UnityEvent<PosRotPair> onEnter;
    public UnityEngine.Events.UnityEvent<PosRotPair> onExit;

    public bool callEventForeachHit = false;
    private void OnCollisionEnter(Collision collision) {
        if(callEventForeachHit) { 
            foreach (ContactPoint contact in collision.contacts)
                onEnter.Invoke(new PosRotPair(contact.point, Quaternion.LookRotation(contact.normal)));
        } else {
            onEnter.Invoke(new PosRotPair(collision.contacts[0].point, Quaternion.LookRotation(collision.contacts[0].normal)));
        }
    }
    
    private void OnCollisionExit(Collision collision) {
        if(callEventForeachHit) { 
            foreach (ContactPoint contact in collision.contacts)
                onExit.Invoke(new PosRotPair(contact.point, Quaternion.LookRotation(contact.normal)));
        } else {
            onExit.Invoke(new PosRotPair(collision.contacts[0].point, Quaternion.LookRotation(collision.contacts[0].normal)));
        }
    }
}
