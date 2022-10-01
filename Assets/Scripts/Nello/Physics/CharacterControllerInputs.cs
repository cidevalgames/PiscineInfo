using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class CharacterControllerInputs : MonoBehaviour {
    public Transform axisProvider; 
    public float multiplier = 1;
    public CharacterController character;
    // public float fowardMove = 0, strafeMove = 0;
    // public void SetForwardAccel(float value) { fowardMove = value; }
    // public void SetStrafeAccel(float value) { strafeMove = value; }

    //! New modifications
    public string axisX = "Horizontal";
    public string axisY = "Vertical";
    public Vector3 movement = Vector3.zero;

    void FixedUpdate() {
        if(axisProvider == null) axisProvider = character.transform;
        // if(fowardMove != 0 || strafeMove != 0) {
        movement.x = Input.GetAxis(axisX) * multiplier;
        movement.z = Input.GetAxis(axisY) * multiplier;
        character.SimpleMove(axisProvider.rotation * movement);
        // }
        character.Move(Physics.gravity * Time.deltaTime);
    }
}
