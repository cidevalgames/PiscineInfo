using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScore : MonoBehaviour
{
    public int collected = 0;

    void Start()
    {
        CanvasManager.manager.scoreLabel.text = "Score : " + collected;
    }

    public void AddCoin()
    {
        collected++;
        CanvasManager.manager.scoreLabel.text = "Score : " + collected;
    }
}
