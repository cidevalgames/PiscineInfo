using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public struct PosRotPair {
    public Vector3 position;
    public Quaternion rotation;

    public PosRotPair(Vector3 position, Quaternion rotation) {
        this.position = position;
        this.rotation = rotation;
    }
}

[System.Serializable]
public struct PosDirPair {
    public Vector3 position;
    public Vector3 direction;

    public PosDirPair(Vector3 position, Vector3 direction) {
        this.position = position;
        this.direction = direction;
    }
}

public class Instantiator : MonoBehaviour {
    public GameObject prefab;
    public Transform parent;
    public void Instantiate() {
        GameObject.Instantiate(prefab, transform.position, transform.rotation, parent);
    }
    public void InstantiateOnHit(PosRotPair hit) {
        GameObject.Instantiate(prefab, hit.position, hit.rotation, parent);
    }
}
