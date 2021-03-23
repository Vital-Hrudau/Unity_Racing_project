using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.IO;
using System;

public class viborCARS : MonoBehaviour
{ 
    public GameObject car1, pickup, suv, police, muscle, pizza1, pizza2, taxi;
    public int numbercar, coins;
    public Animation butNext, butPrev;
    public Text coinTxt, vehtext, price;
    public GameObject star1, star2, star3, BUY, choosemap;
    public GameObject had1, had2, had3;
    public int buypickup, buysuv, buypolice, buymuscle, buypiz1, buypiz2, buytaxi;
    public GameObject buyimg;
    public AudioSource buysound; //prevsound, nextsound;




	void Start () {

        coins = PlayerPrefs.GetInt("coins", coins);
        Time.timeScale = 1;
        startprefs();
        buyimg.SetActive(false);
        coinTxt.text = coins.ToString();
        vehtext.text = vehtext.ToString();
        price.text = price.ToString();
        if (numbercar == 1)
        {
            choosemap.SetActive(true);
            BUY.SetActive(false);
        }
       
    }
	
	void Update ()
    {
        
        loadupdate();
        if (numbercar == 1)
        {
            choosemap.SetActive(true);
            BUY.SetActive(false);
        }
        if (numbercar == 2)
        {
            if (buypickup == 0)
            {
                choosemap.SetActive(false);
                BUY.SetActive(true);
            }
            if (buypickup == 1)
            {
                choosemap.SetActive(true); BUY.SetActive(false);
            }          
        }
        if (numbercar == 3)
        {
            if (buysuv == 0)
            {
                choosemap.SetActive(false);
                BUY.SetActive(true);
            }
            if (buysuv == 1)
            {
                choosemap.SetActive(true); BUY.SetActive(false);
            }
        }

        if (numbercar == 4 )
        {
            if (buypolice == 0)
            {
                choosemap.SetActive(false);
                BUY.SetActive(true);
            }
            if (buypolice == 1)
            {
                choosemap.SetActive(true); BUY.SetActive(false);
            }
        }

        if (numbercar == 5 )
        {
            if (buymuscle == 0)
            {
                choosemap.SetActive(false);
                BUY.SetActive(true);
            }
            if (buymuscle == 1)
            {
                choosemap.SetActive(true); BUY.SetActive(false);
            }
        }
        if (numbercar == 6 )
        {
            if (buypiz1 == 0)
            {
                choosemap.SetActive(false);
                BUY.SetActive(true);
            }
            if (buypiz1 == 1)
            {
                choosemap.SetActive(true); BUY.SetActive(false);
            }
        }
        if (numbercar == 7 )
        {
            if (buypiz2 == 0)
            {
                choosemap.SetActive(false);
                BUY.SetActive(true);
            }
            if (buypiz2 == 1)
            {
                choosemap.SetActive(true); BUY.SetActive(false);
            }
        }
        if (numbercar == 8 )
        {
            if (buytaxi == 0)
            {
                choosemap.SetActive(false);
                BUY.SetActive(true);
            }
            if (buytaxi == 1)
            {
                choosemap.SetActive(true); BUY.SetActive(false);
            }
        }
        if (numbercar >= 8) // change wile add cars (VEHICLE)
        {
            numbercar = 8;
        }
        if (numbercar <= 1) 
        {
            numbercar = 1;
        }
    }
   
    public void yesbuy()
    {
        if (numbercar == 2)
        {
            if(coins >= 300)
            {
                coins = coins - 300;
                buysound.Play();   
                buypickup = 1;
                PlayerPrefs.SetInt("buypickup", buypickup);
                choosemap.SetActive(true);
                BUY.SetActive(false); 
                PlayerPrefs.Save();
                buyimg.SetActive(false);
                SceneManager.LoadScene(0);
            }
        }
        if (numbercar == 3)
        {
            if (coins >= 400)
            {
                coins = coins - 400;
                buysound.Play();
                buysuv = 1;
                PlayerPrefs.SetInt("buysuv", buysuv);
                choosemap.SetActive(true);
                BUY.SetActive(false);
                PlayerPrefs.Save();
                buyimg.SetActive(false);
                SceneManager.LoadScene(0);
            }
        }
        if (numbercar == 4)
        {
            if (coins >= 1200)
            {
                coins = coins - 1200;
                buysound.Play();
                buypolice = 1;
                PlayerPrefs.SetInt("buypolice", buypolice);
                choosemap.SetActive(true);
                BUY.SetActive(false);
                PlayerPrefs.Save();
                buyimg.SetActive(false);
                SceneManager.LoadScene(0);
            }
        }
        if (numbercar == 5)
        {
            if (coins >= 800)
            {
                coins = coins - 800;
                buysound.Play();
                buymuscle = 1; 
                PlayerPrefs.SetInt("buymuscle", buymuscle);
                choosemap.SetActive(true);
                BUY.SetActive(false);
                PlayerPrefs.Save();
                buyimg.SetActive(false);
                SceneManager.LoadScene(0);
            }
        }
        if (numbercar == 6)
        {
            if (coins >= 600)
            {
                coins = coins - 600;
                buysound.Play();
                buypiz1 = 1;
                PlayerPrefs.SetInt("buypiz1", buypiz1);
                choosemap.SetActive(true);
                BUY.SetActive(false);
                PlayerPrefs.Save();
                buyimg.SetActive(false);
                SceneManager.LoadScene(0);
            }
        }
        if (numbercar == 7)
        {
            if (coins >= 500)
            {
                coins = coins - 500;
                buysound.Play();
                buypiz2 = 1;
                PlayerPrefs.SetInt("buypiz2", buypiz2);
                choosemap.SetActive(true);
                BUY.SetActive(false);
                PlayerPrefs.Save();
                buyimg.SetActive(false);
                SceneManager.LoadScene(0);
            }
        }
        if (numbercar == 8)
        {
            if (coins >= 1000)
            {
                coins = coins - 1000;
                buysound.Play();
                buytaxi = 1;
                PlayerPrefs.SetInt("buytaxi", buytaxi);
                choosemap.SetActive(true);
                BUY.SetActive(false);
                PlayerPrefs.Save();
                buyimg.SetActive(false);
                SceneManager.LoadScene(0);
            }
        }
    }
    public void Buy()
    {
        if (numbercar == 2 )
        {
            buyimg.SetActive(true);
            vehtext.text = ("pickup");
            price.text = ("300");
        }
        if (numbercar == 3)
        {
            buyimg.SetActive(true);
            vehtext.text = ("suv");
            price.text = ("400");
        }
        if (numbercar == 4)
        {
            buyimg.SetActive(true);
            vehtext.text = ("police");
            price.text = ("1200");
        }
        if (numbercar == 5)
        {
            buyimg.SetActive(true);
            vehtext.text = ("muscle");
            price.text = ("800");
        }
        if (numbercar == 6)
        {
            buyimg.SetActive(true);
            vehtext.text = ("pizza boy");
            price.text = ("600");
        }
        if (numbercar == 7)
        {
            buyimg.SetActive(true);
            vehtext.text = ("hot van");
            price.text = ("500");
        }
        if (numbercar == 8)
        {
            buyimg.SetActive(true);
            vehtext.text = ("taxi");
            price.text = ("1000");
        }
    }
    public void nobuy()
    {
        buyimg.SetActive(false);
    }
    public void LoadScene()
    {
        SceneManager.LoadScene(1);
    }
    public void next()
    {
        numbercar = numbercar + 1;
        butNext.Play();
        //nextsound.Play();
        PlayerPrefs.Save();
    }
    public void prev()
    {
        numbercar = numbercar - 1;
        butPrev.Play();
        //prevsound.Play();
        PlayerPrefs.Save();
    }
    void stars1()
    {
        star1.SetActive(true);
        star2.SetActive(false);
        star3.SetActive(false);
    }
    void stars2()
    {
        star1.SetActive(true);
        star2.SetActive(true);
        star3.SetActive(false);
    }
    void stars3()
    {
        star1.SetActive(true);
        star2.SetActive(true);
        star3.SetActive(true);
    }
    void hadl1()
    {
        had1.SetActive(true);
        had1.SetActive(false);
        had1.SetActive(false);
    }
    void hadl2()
    {
        had1.SetActive(true);
        had1.SetActive(true);
        had1.SetActive(false);
    }
    void hadl3()
    {
        had1.SetActive(true);
        had1.SetActive(true);
        had1.SetActive(true);
    }
    void startprefs()
    {
        if (!PlayerPrefs.HasKey("numbercar"))
        {
            PlayerPrefs.SetInt("numbercar", 0);
        }
        if (!PlayerPrefs.HasKey("coins"))
        {
            PlayerPrefs.SetInt("coins", 0);
        }
        if (!PlayerPrefs.HasKey("buypickup"))
        {
            PlayerPrefs.SetInt("buypickup", 0);
        }
        if (!PlayerPrefs.HasKey("buysuv"))
        {
            PlayerPrefs.SetInt("buysuv", 0);
        }
        if (!PlayerPrefs.HasKey("buypolice"))
        {
            PlayerPrefs.SetInt("buypolice", 0);
        }
        if (!PlayerPrefs.HasKey("buymuscle"))
        {
            PlayerPrefs.SetInt("buymuscle", 0);
        }
        if (!PlayerPrefs.HasKey("buypiz1"))
        {
            PlayerPrefs.SetInt("buypiz1", 0);
        }
        if (!PlayerPrefs.HasKey("buypiz2"))
        {
            PlayerPrefs.SetInt("buypiz2", 0);
        }
        if (!PlayerPrefs.HasKey("buytaxi"))
        {
            PlayerPrefs.SetInt("buytaxi", 0);
        }
        
        numbercar = PlayerPrefs.GetInt("numbercar", numbercar);
        buypickup = PlayerPrefs.GetInt("buypickup", buypickup);
        buysuv = PlayerPrefs.GetInt("buysuv", buysuv);
        buymuscle = PlayerPrefs.GetInt("buymuscle", buymuscle);
        buypolice = PlayerPrefs.GetInt("buypolice", buypolice);
        buypiz1 = PlayerPrefs.GetInt("buypiz1", buypiz1);
        buypiz2 = PlayerPrefs.GetInt("buypiz2", buypiz2);
        buytaxi = PlayerPrefs.GetInt("buytaxi", buytaxi); 
        
    }
    void loadupdate()
    {
        PlayerPrefs.SetInt("numbercar", numbercar);
        PlayerPrefs.SetInt("coins", coins);
        PlayerPrefs.SetInt("buypickup", buypickup);
        PlayerPrefs.SetInt("buysuv", buysuv);
        PlayerPrefs.SetInt("buypolice", buypolice);
        PlayerPrefs.SetInt("buymuscle", buymuscle);
        PlayerPrefs.SetInt("buypiz1", buypiz1);
        PlayerPrefs.SetInt("buypiz2", buypiz2);
        PlayerPrefs.SetInt("buytaxi", buytaxi);
        if (numbercar == 1) { car1.SetActive(true); stars1(); hadl2(); } else car1.SetActive(false);
        if (numbercar == 2) { pickup.SetActive(true); stars1(); hadl2(); } else pickup.SetActive(false);
        if (numbercar == 3) { suv.SetActive(true); stars2(); hadl1(); } else suv.SetActive(false);
        if (numbercar == 4) { police.SetActive(true); stars3(); hadl3(); } else police.SetActive(false);
        if (numbercar == 5) { muscle.SetActive(true); stars3(); hadl3(); } else muscle.SetActive(false);
        if (numbercar == 6) { pizza1.SetActive(true); stars2(); hadl1(); } else pizza1.SetActive(false);
        if (numbercar == 7) { pizza2.SetActive(true); stars2(); hadl1(); } else pizza2.SetActive(false);
        if (numbercar == 8) { taxi.SetActive(true); stars3(); hadl3(); } else taxi.SetActive(false);
    }
}
