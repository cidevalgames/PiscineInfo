using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndScreen : MonoBehaviour
{
    public GameObject endCamera;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        PlayerScore scoring = other.GetComponent<PlayerScore>();

        if(scoring)
        {
            Cursor.lockState = CursorLockMode.None;

            CanvasManager.manager.endPannel.SetActive(true);
            CanvasManager.manager.score.SetActive(false);

            CanvasManager.manager.endScoreLabel.text = "Score : " + scoring.collected;
            CanvasManager.manager.highScoreLabel.text = "High score : " + scoring.collected;

            endCamera.SetActive(true);
            
            Destroy(other.gameObject);
        }
    }
}
