using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateTransform : MonoBehaviour {
    public Space space;
    public void RotateY(float degrees) {
        transform.Rotate(Vector3.up * degrees, space);
    }
    public void RotateX(float degrees) {
        transform.Rotate(Vector3.right * degrees, space);
    }
    public void RotateZ(float degrees) {
        transform.Rotate(Vector3.forward * degrees, space);
    }
    public void SetRotationY(float degrees) {
        Vector3 eulers = transform.localEulerAngles;
        eulers.y = degrees;
        transform.localEulerAngles = eulers;
    }
    public void SetRotationX(float degrees) {
        Vector3 eulers = transform.localEulerAngles;
        eulers.x = degrees;
        transform.localEulerAngles = eulers;
    }
    public void SetRotationZ(float degrees) {
        Vector3 eulers = transform.localEulerAngles;
        eulers.z = degrees;
        transform.localEulerAngles = eulers;
    }
}
