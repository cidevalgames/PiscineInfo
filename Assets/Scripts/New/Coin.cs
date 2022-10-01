using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    public AudioSource instantiateOnDeath;

    public float frequency = 1;
    public float range = 1;
    public float yOffset;
    public float time = 1;
    public float rotSpeed = 30;
    
    void Update() 
    {
        float delay = frequency * (transform.position.z + transform.position.x);
        
        transform.localPosition = new Vector3(0, yOffset + range * Mathf.Sin(delay + Time.time * time * Mathf.PI), 0);
        transform.localEulerAngles = new Vector3(0, delay * rotSpeed + Time.time * rotSpeed, 0);
    }
    
    private void OnTriggerEnter(Collider other) 
    {
        PlayerScore scoring = other.GetComponent<PlayerScore>();

        if(scoring != null) {
            // scoring.collected++;

            scoring.AddCoin();

            Destroy(this.gameObject);

            GameObject instantiated = GameObject.Instantiate(instantiateOnDeath.gameObject, transform.position, transform.rotation);
            Destroy(instantiated, instantiated.GetComponent<AudioSource>().clip.length);
        }
    }
}
