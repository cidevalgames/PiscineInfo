using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetPosRot : MonoBehaviour
{
    public void SetPos(Vector3 pos) {
        transform.position = pos;
    }
    public void SetRot(Quaternion rot) {
        transform.rotation = rot;
    }
    public void SetPos(PosRotPair pos) {
        transform.position = pos.position;
    }
    public void SetRot(PosRotPair rot) {
        transform.rotation = rot.rotation;
    }
    public void SetPair(Vector3 pos, Quaternion rot) {
        transform.SetPositionAndRotation(pos, rot);
    }
    public void SetPair(PosRotPair pair) {
        transform.SetPositionAndRotation(pair.position, pair.rotation);
    }
}
