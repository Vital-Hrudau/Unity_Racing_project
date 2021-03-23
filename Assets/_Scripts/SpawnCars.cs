using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnCars : MonoBehaviour {

    public GameObject car, pickip, suv, police, muscle, pizza1, pizza2, taxi;
    public int numbercar;

	void Start () {
        numbercar = PlayerPrefs.GetInt("numbercar", numbercar);
    }
	
	
	void Update () {
        PlayerPrefs.SetInt("numbercar", numbercar);
        if (numbercar == 1)
        {
            car.SetActive(true);
        }
        else car.SetActive(false);
        if (numbercar == 2)
        {
            pickip.SetActive(true);
        }
        else pickip.SetActive(false);
        if (numbercar == 3)
        {
            suv.SetActive(true);
        }
        else suv.SetActive(false);
        if (numbercar == 4)
        {
            police.SetActive(true);
        }
        else police.SetActive(false);
        if (numbercar == 5)
        {
            muscle.SetActive(true);
        }
        else muscle.SetActive(false);
        if (numbercar == 6)
        {
            pizza1.SetActive(true);
        }
        else pizza1.SetActive(false);
        if (numbercar == 7)
        {
            pizza2.SetActive(true);
        }
        else pizza2.SetActive(false);
        if (numbercar == 8)
        {
            taxi.SetActive(true);
        }
        else taxi.SetActive(false);
    }
}
