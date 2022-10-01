using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shotgun : MonoBehaviour
{
    public GameObject bulletPrefab;
    public Transform parent;
    
    public int bulletsNumber = 10;
    public float accumulator;
    public float threshold = 1f / 3f;

    [Header("Random Position")]
    public Vector2 positionMin;
    public Vector2 positionMax;

    [Header("Random Rotation")]
    public Vector3 rotationMin;
    public Vector3 rotationMax;

    void Start() 
    {
        accumulator = threshold;
    }

    void Update()
    {
        if(Input.GetButton("Fire") || Input.GetAxis("Fire Controller") > 0)
        {
            accumulator += Time.deltaTime;

            if(accumulator >= threshold)
            {
                for(int i = 0 ; i < bulletsNumber ; i++)
                {
                    // Changes the position and rotation of the parent in a random range
                    transform.localPosition = new Vector3(Random.Range(positionMin.x, positionMax.x), Random.Range(positionMin.y, positionMax.y), 0.5f);
                    transform.localEulerAngles = new Vector3(Random.Range(rotationMin.x, rotationMax.x), Random.Range(rotationMin.y, rotationMax.y), Random.Range(rotationMin.z, rotationMax.z));

                    // Instantiation of a bullet
                    GameObject.Instantiate(bulletPrefab, transform.position, transform.rotation, parent);
                }

                accumulator = 0;
            }
        }

        if(Input.GetButtonUp("Fire"))
        {
            accumulator = threshold;
        }
    }
}
