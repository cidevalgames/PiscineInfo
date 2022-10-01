using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponnarySelector : MonoBehaviour
{
    public int selectedIndex = 0;
    public GameObject[] weapons;

    void Select(int index)
    {
        index = index % weapons.Length;

        for(int i = 0 ; i < weapons.Length ; i++)
        {
            weapons[i].SetActive(i == index);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        Select(selectedIndex);    
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("ChangeWeapon") || Input.GetButtonDown("ChangeWeapon Controller"))
        {
            selectedIndex++;

            Select(selectedIndex);
        }
    }
}
