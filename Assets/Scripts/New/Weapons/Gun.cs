using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    public GameObject bulletPrefab;
    public Transform parent;
    public float accumulator;
    public float threshold = 1f / 3f;
        
    // Start is called before the first frame update
    void Start()
    {
        accumulator = threshold;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButton("Fire") || Input.GetAxis("Fire Controller") > 0)
        {
            accumulator += Time.deltaTime;

            if(accumulator >= threshold)
            {
                GameObject.Instantiate(bulletPrefab, transform.position, transform.rotation, parent);
                accumulator = 0;
            }

        }

        if(Input.GetButtonUp("Fire"))
        {
            accumulator = threshold / 2f;
        }
    }
}
