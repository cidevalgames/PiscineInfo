using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using NelowGames;

namespace NelowGames {
    public class CursorLocker : MonoBehaviour {
        public CursorLockMode lockModeA = CursorLockMode.Locked;
        public CursorLockMode lockModeB = CursorLockMode.None;
        bool isA;
        private void Start() {
            isA = true;
            Cursor.lockState = lockModeA;
        }
        void Update() {
            if (Input.GetKey(KeyCode.Escape)) {
                isA = !isA;
                Cursor.lockState = isA ? lockModeA : lockModeB;
            }
        }
    }
}