using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mapAm2 : MonoBehaviour {

    public int map1;
    void Start()
    {
        if (!PlayerPrefs.HasKey("map1"))
        {
            PlayerPrefs.SetInt("map1", 1);
        }
        map1 = PlayerPrefs.GetInt("map1", map1);
        map1 = 2;
    }


    void Update()
    {
        PlayerPrefs.SetInt("map1", map1);
        if (map1 == 2)
        {
            map1 = 2;
        }
    }
}
