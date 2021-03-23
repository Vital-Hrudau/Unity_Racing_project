
using UnityEngine;
using System.IO;
using System;
using System.Collections;
using System.Collections.Generic;

public class BUTnext : MonoBehaviour {

    public Animation But;
    public int number;


    void Start()
    {
        if (!PlayerPrefs.HasKey("numbercar"))
        {
            PlayerPrefs.SetInt("numbercar", 0);
        }
        
        PlayerPrefs.SetInt("numbercar", number);
    }

    void Update()
    {
        PlayerPrefs.SetInt("numbercar", number);
        //int numbercar = PlayerPrefs.GetInt("numbercar", number);
    }
    private void OnMouseDown()
    {
        //int numbercar = PlayerPrefs.GetInt("numbercar", number);
        number = number + 1;
        But.Play();
        PlayerPrefs.Save();
    }
}
