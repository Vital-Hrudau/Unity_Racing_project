using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class triggerCar : MonoBehaviour {

    public int life, coin, coins, speedcoin, speedOver, recCoins1, recCoins2;
    public GameObject coinObj;
    public Text Coins, scoreImg, recCoins;
    private int CurrentScore;
    private float checkPos;
    public Image imgover;
    private RectTransform rec;
    public int map1, map2;
    public AudioSource crash, scoreAdd;
   

    void Start () {   
        speedOver = 10;
        coin = 0;
        coins = PlayerPrefs.GetInt("coins", coins);
        if (!PlayerPrefs.HasKey("map1"))
        {
            PlayerPrefs.SetInt("map1", 0);
        }
        if (!PlayerPrefs.HasKey("map2"))
        {
            PlayerPrefs.SetInt("map2", 0);
        }
        if (!PlayerPrefs.HasKey("coins"))
        {
            PlayerPrefs.SetInt("coins", 0);
        }
        if (!PlayerPrefs.HasKey("recCoins1"))
        {
            PlayerPrefs.SetInt("recCoins1", 0);
        }
        if (!PlayerPrefs.HasKey("recCoins2"))
        {
            PlayerPrefs.SetInt("recCoins2", 0);
        }
        map1 = PlayerPrefs.GetInt("map1", map1);
        map2 = PlayerPrefs.GetInt("map2", map2);
        if (map1 == 1)
        {
            recCoins1 = PlayerPrefs.GetInt("recCoins1", recCoins1);
        }
        if (map2 == 1)
        {
            recCoins2 = PlayerPrefs.GetInt("recCoins2", recCoins2);  
        }  
        rec = imgover.GetComponent<RectTransform>();
    }
	
	void Update () {
        CurrentScore = (int)coin;
        Coins.text = CurrentScore.ToString();
        scoreImg.text = CurrentScore.ToString();
        PlayerPrefs.SetInt("coins", coins);
        PlayerPrefs.SetInt("map1", map1);
        PlayerPrefs.SetInt("map2", map2);
        if (map1 == 1)
        {
            PlayerPrefs.SetInt("recCoins1", recCoins1);
        }
        if (map2 == 1)
        {
            PlayerPrefs.SetInt("recCoins2", recCoins2);
        }
        if (map1 == 1)
        {
            recCoins.text = recCoins1.ToString();
            //recCoins.text = recCoins1;
            if (coin > recCoins1)
            {
                PlayerPrefs.SetInt("recCoins1", coin);
                PlayerPrefs.Save();
            }
        }
        if (map2 == 1)
        {
            recCoins.text = recCoins2.ToString();
           // recCoins.text = (recCoins2 + "m");
            if (coin > recCoins2)
            {
                PlayerPrefs.SetInt("recCoins2", coin);
                PlayerPrefs.Save();
            }
        } 
         if (life >=1)
        {
            if (rec.offsetMin.y != checkPos)
            {
                rec.offsetMin -= new Vector2(rec.offsetMin.x, speedOver);
                rec.offsetMax -= new Vector2(rec.offsetMax.x, speedOver);
            }
            Time.timeScale = 0;
        }
       

    }
    private void OnCollisionEnter(Collision collision)
    {
        life++;
        crash.Play();
    }
    private void OnTriggerEnter(Collider con)
    {
        if (con.gameObject.tag == "coin")
        {
            coin = coin +1;
            coins = coins + 1;
            scoreAdd.Play();
            PlayerPrefs.Save();
            Destroy(con.gameObject);        
        }
    }
}
