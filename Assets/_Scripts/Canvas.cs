using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Canvas : MonoBehaviour
{

    public int numbercar;
    public GameObject l1, r1, l2, r2;
    public GameObject left, right;
    public Image left1;


    void Start()
    {
        numbercar = PlayerPrefs.GetInt("numbercar", numbercar);
        
    }




    void Update()
    {
        numbercar = PlayerPrefs.GetInt("numbercar", numbercar);
        PlayerPrefs.SetInt("numbercar", numbercar);
        if (numbercar == 1)
        {
            l1.SetActive(true);
           
            r1.SetActive(true);
            left.SetActive(true);
            right.SetActive(true);
        }
        l1.SetActive(false); r1.SetActive(false);
        if (numbercar == 2)
        {
            l2.SetActive(true);
            r2.SetActive(true);

        }
        l2.SetActive(false); r2.SetActive(false);
    }
}
