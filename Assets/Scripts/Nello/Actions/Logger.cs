using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Logger : MonoBehaviour {
    public void Log(string str) {
        Debug.Log(str);
    }
    public void LogName(GameObject obj) {
        Debug.Log(obj.name);
    }
}
