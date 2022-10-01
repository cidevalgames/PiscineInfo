using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using NelowGames;

namespace NelowGames {
    public class TimeEvent : MonoBehaviour {
        public float timeSpeed = 1;
        public float delay = 0;
        public UnityEngine.Events.UnityEvent<float> eachFrame;
        float t;
        void Start() {
            t = Time.time + delay;
        }
        void Update() {
            t += Time.deltaTime * timeSpeed;
            eachFrame.Invoke(t);
        }
    }
}