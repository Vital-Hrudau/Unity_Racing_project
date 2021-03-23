using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButScript : MonoBehaviour {


    public int numbercar;
    public GameObject car, pickup, suv, police, piz1, piz2, taxi, muscle;
  


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
            car.gameObject.SetActive(true);
        }
        else car.gameObject.SetActive(false);
        if (numbercar == 2)
        {
            pickup.gameObject.SetActive(true);
          
        }
        else pickup.gameObject.SetActive(false);
        if (numbercar == 3)
        {
            suv.gameObject.SetActive(true);

        }
        else suv.gameObject.SetActive(false);
        if (numbercar == 4)
        {
            police.gameObject.SetActive(true);

        }else police.gameObject.SetActive(false);
        if (numbercar == 5)
        {
            muscle.gameObject.SetActive(true);

        }
        else muscle.gameObject.SetActive(false);
        if (numbercar == 6)
        {
            piz1.gameObject.SetActive(true);

        }
        else piz1.gameObject.SetActive(false);
        if (numbercar == 7)
        {
            piz2.gameObject.SetActive(true);

        }
        else piz2.gameObject.SetActive(false);
        if (numbercar == 8)
        {
            taxi.gameObject.SetActive(true);

        }
        else taxi.gameObject.SetActive(false);



    }
}
