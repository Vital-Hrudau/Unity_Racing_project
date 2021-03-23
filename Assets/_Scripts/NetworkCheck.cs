using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class NetworkCheck : MonoBehaviour {

    public int internet;
    public GameObject bonusON, bonusOFF, adveriselist;
    public bool showview;
    public int coins;
    int ad = 50;

    private void Start()
    {
        coins = PlayerPrefs.GetInt("coins", coins);
        adveriselist.SetActive(false);
       
    }
    void Update() {
        PlayerPrefs.SetInt("coins", coins);
        if (Application.internetReachability != NetworkReachability.NotReachable)
        {
            internet = 1;
            bonusON.SetActive(true);
            bonusOFF.SetActive(false);
        }
        else
             internet = 0;
        bonusOFF.SetActive(true);
        bonusON.SetActive(false);
        if (internet == 1)
        {
            bonusON.SetActive(true);
            bonusOFF.SetActive(false);
        }
        if (internet == 0)
        {
            bonusOFF.SetActive(true);
            bonusON.SetActive(false);
        }
        if (showview == true)
        {
            bonusOFF.SetActive(true);
            bonusON.SetActive(false);
        }
    }
    public void AdvertiseShow()
    {
        if (internet == 1)
        {
            coins = coins + ad;
            showview = true;
            adveriselist.SetActive(false);
            PlayerPrefs.Save();
            //SceneManager.LoadScene(0);
        }
    } 
    public void ShowAdList()
    {
        adveriselist.SetActive(true);
    }
    public void closeAd()
    {
        adveriselist.SetActive(false);
    }
	
	
}
