using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 20;
    public float force = 1;
    public int bounceCount = 1;
    public LayerMask layers = -1;
    private Vector3 lastPos;

    void OnEnable()
    {
        lastPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime, Space.Self);
    }

    void LateUpdate() {
        DoRaycast();
        lastPos = transform.position;
    }

    public void DoRaycast() {
        Vector3 v = transform.position - lastPos;
        float l = v.magnitude;

        RaycastHit rch;
        if(Physics.Raycast(lastPos, v, out rch, l, layers)) {

            RaycastHitObject o = rch.collider.GetComponent<RaycastHitObject>();
            PosDirPair dirPair = new PosDirPair(rch.point, force * (v/l));
            // HitAction.Invoke(dirPair);
            if(o) o.OnImpact(dirPair);

            PosRotPair rotPair = new PosRotPair(rch.point, Quaternion.LookRotation(rch.normal));
            // HitNormalAction.Invoke(rotPair);
            if(o) o.OnImpactNormal(rotPair);

            Rigidbody body = rch.collider.GetComponent<Rigidbody>();

            if(body != null)
            {
                body.AddForceAtPosition(v.normalized * force, rch.point, ForceMode.Impulse);
                // body.AddForceAtPosition((v / l) * force, rch.point, ForceMode.Impulse);
            }

            if(bounceCount == 0)
            {
                Destroy(gameObject);
            }
            else
            {
                bounceCount--;
                transform.forward = rch.normal;
            }
        }
    }
}
