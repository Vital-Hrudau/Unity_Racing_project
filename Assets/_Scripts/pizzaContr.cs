using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class pizzaContr : MonoBehaviour {

    private int CurrentScore; //перемменая для счета опита (лутше не трогать)
    public float km = 0;  //начальный километраж
    public int AddKM = 0; //добавление км в секунду
    public float Speed = 1; //начальная скорость игрока или обьекта
    public float addSpeed = 0; //добавление скорости в секунду 
    public float SpeedMax = 0; //максимальная скрорость игрока или обьекта
    public GameObject car, coinObj;
    public int Wheelspeed, coin, wheel;
    public Text Distance, distOver, recDist;
    public int rec1, map1, map2, rec2;

    private void Start()
    {
        if (!PlayerPrefs.HasKey("rec1"))
        {
            PlayerPrefs.SetInt("rec1", 0);
        }
        if (!PlayerPrefs.HasKey("rec2"))
        {
            PlayerPrefs.SetInt("rec2", 0);
        }
        if (!PlayerPrefs.HasKey("map1"))
        {
            PlayerPrefs.SetInt("map1", 0);
        }
        if (!PlayerPrefs.HasKey("map2"))
        {
            PlayerPrefs.SetInt("map2", 0);
        }
        map1 = PlayerPrefs.GetInt("map1", map1);
        map2 = PlayerPrefs.GetInt("map2", map2);
        rec1 = PlayerPrefs.GetInt("rec1", rec1);
        rec2 = PlayerPrefs.GetInt("rec2", rec2);
        wheel = 0;
        if (map1 == 1)
        {
            rec1 = PlayerPrefs.GetInt("rec1", CurrentScore);
        }
        if (map1 == 2)
        {
            rec2 = PlayerPrefs.GetInt("rec2", CurrentScore);
        }

    }
    void Update()
    {
        if (map1 == 1)
        {
            PlayerPrefs.SetInt("rec1", rec1);
        }
        if (map2 == 2)
        {
            PlayerPrefs.SetInt("rec2", rec2);
        }
        PlayerPrefs.SetInt("map1", map1);
        PlayerPrefs.SetInt("map2", map2);
        gameObject.transform.Translate(0, 0, 1 * Speed * Time.deltaTime);
        //car.transform.position = car.transform.forward * Speed * Time.deltaTime;
        if (Speed <= SpeedMax)
        {
            Speed += addSpeed * Time.deltaTime;
        }
        km += AddKM * Time.deltaTime;
        CurrentScore = (int)km;
        Distance.text = CurrentScore.ToString();
        distOver.text = CurrentScore.ToString();
        distOver.text = (CurrentScore + "m");
        Distance.text = (CurrentScore + "m");
        if (map1 == 1)
        {
            recDist.text = rec1.ToString();
            recDist.text = (rec1 + "m");
            if (CurrentScore > rec1)
            {
                PlayerPrefs.SetInt("rec1", CurrentScore);
                PlayerPrefs.Save();
            }
        }
        if (map2 == 1)
        {
            recDist.text = rec2.ToString();
            recDist.text = (rec2 + "m");
            if (CurrentScore > rec2)
            {
                PlayerPrefs.SetInt("rec2", CurrentScore);
                PlayerPrefs.Save();
            }
        }

        if (Input.GetKey(KeyCode.D))
        {
            car.transform.position -= car.transform.right * Wheelspeed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.A))
        {
            car.transform.position += car.transform.right * Wheelspeed * Time.deltaTime;
        }
        if (wheel >= 2)// RIGHT
        {
            car.transform.position -= car.transform.right * Wheelspeed * Time.deltaTime;
        }
        if (wheel <= -1)//LEFT
        {
            car.transform.position += car.transform.right * Wheelspeed * Time.deltaTime;
        }
        if (Speed > 40)
        {
            AddKM = 5;
        }
        if (Speed > 60)
        {
            AddKM = 6;
        }
        if (Speed > 80)
        {
            AddKM = 7;
        }
        if (Speed > 100)
        {
            AddKM = 8;
        }
        if (Speed > 120)
        {
            AddKM = 9;
        }
        if (Speed > 130)
        {
            AddKM = 10;
        }
        if (Speed > 160)
        {
            AddKM = 12;
        }

    }

    public void Right()
    {
        wheel = 2;
    }
    public void RightUP()
    {
        wheel = 0;
    }
    public void Left()
    {
        wheel = -2;
    }
    public void LeftUP()
    {
        wheel = 0;
    }
}
