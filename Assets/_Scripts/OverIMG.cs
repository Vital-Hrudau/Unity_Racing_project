using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class OverIMG : MonoBehaviour {

    public int coins;
    public Text Mytxt, cointext;
    private int curret;
    public int map1, map2;
    

    void Start () {
        map1 = 0;
        map2 = 0;
        coins = PlayerPrefs.GetInt("coins", coins);
        map1 = PlayerPrefs.GetInt("map1", map1);
        map2 = PlayerPrefs.GetInt("map2", map2);
    }
	
	
	void Update () {
        PlayerPrefs.SetInt("coins", coins);
        PlayerPrefs.SetInt("map1", map1);
        PlayerPrefs.SetInt("map2", map2);
    }
    public void Exit()
    {
        map1 = 0; map2 = 0;
        PlayerPrefs.Save();
        SceneManager.LoadScene(0);
        Time.timeScale = 1;

    }
    public void Restart()///1
    {
        SceneManager.LoadScene(1);
    }
    public void Restart2()///2
    {
        SceneManager.LoadScene(2);
    }
   


}

