using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class CanvasManager : MonoBehaviour
{
    public static CanvasManager manager;
    public Text scoreLabel;
    public Text endScoreLabel;
    public Text highScoreLabel;
    public GameObject score;
    public GameObject endPannel;

    private void Awake()
    {
        manager = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
