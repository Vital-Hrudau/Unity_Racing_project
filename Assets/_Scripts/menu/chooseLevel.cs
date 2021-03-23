using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class chooseLevel : MonoBehaviour {

    public GameObject levelimg, singleOn, singleOFF, multiplON, multiOFF;
    public GameObject freeride, pizzaboy, traffic, taxidriver, simplecity1, urbancity1;
    public GameObject freerideOFF, pizzaboyOFF, trafficOFF, taxidriverOFF, textSimple,textUrban, soonText;
    public int map1, map2;
    public AudioSource backsound;


    void Start () {
        levelimg.SetActive(false);
        soonText.SetActive(false);
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
        map1 = 0;
        map2 = 0;
        singleOn.SetActive(true);
        singleOFF.SetActive(false);
        multiOFF.SetActive(true);
        multiplON.SetActive(false);
        soonText.SetActive(false);
        freeride.SetActive(true);
        pizzaboy.SetActive(true);
        traffic.SetActive(true);
        taxidriver.SetActive(true);
        pizzaboyOFF.SetActive(true);
        trafficOFF.SetActive(true);
        taxidriverOFF.SetActive(true);
        simplecity1.SetActive(true);
        urbancity1.SetActive(true);
        taxidriverOFF.SetActive(true);
        textSimple.SetActive(true);
        textUrban.SetActive(true);
    }
	
	
	void Update () {
        PlayerPrefs.SetInt("map1", map1);
        PlayerPrefs.SetInt("map2", map2);
        if (Application.platform == RuntimePlatform.Android)
        {
            if (Input.GetKey(KeyCode.Home) || Input.GetKey(KeyCode.Escape) || Input.GetKey(KeyCode.Menu))
            {
                Application.Quit();
                return;
                //print("exit");

            }
        }

    }
    public void level1open()
    {
        map1 = 1;
        SceneManager.LoadScene(1);
    }
    public void level2open()
    {
        map2 = 1;
        SceneManager.LoadScene(2);
    }
    public void exit()
    {
        levelimg.SetActive(false);
        soonText.SetActive(false);
        backsound.Play();
    }
    public void openlevelimg()
    {
        levelimg.SetActive(true);
    }
    public void singlclick()
    {
        singleOn.SetActive(true);
        singleOFF.SetActive(false);
        multiOFF.SetActive(true);
        multiplON.SetActive(false);
        soonText.SetActive(false);
        freeride.SetActive(true);
        pizzaboy.SetActive(true);
        traffic.SetActive(true);
        taxidriver.SetActive(true);
        pizzaboyOFF.SetActive(true);
        trafficOFF.SetActive(true);
        taxidriverOFF.SetActive(true);
        simplecity1.SetActive(true);
        urbancity1.SetActive(true);
        taxidriverOFF.SetActive(true);
        textSimple.SetActive(true);
        textUrban.SetActive(true);

    }
    public void multiclick()
    {
        singleOFF.SetActive(true);
        multiplON.SetActive(true);
        multiOFF.SetActive(false);
        soonText.SetActive(true);
        freeride.SetActive(false);
        pizzaboy.SetActive(false);
        traffic.SetActive(false);
        taxidriver.SetActive(false);
        simplecity1.SetActive(false);
        urbancity1.SetActive(false);
        freerideOFF.SetActive(false);
        pizzaboyOFF.SetActive(false);
        trafficOFF.SetActive(false);
        taxidriverOFF.SetActive(false);
        textSimple.SetActive(false);
        textUrban.SetActive(false);



    }
    public void freerideclick()
    {
        ////
        textSimple.SetActive(true);
        textUrban.SetActive(true);
        soonText.SetActive(false);
        ///
        simplecity1.SetActive(true);
        urbancity1.SetActive(true);
        freeride.SetActive(true);
        freerideOFF.SetActive(false);
        pizzaboy.SetActive(false);
        traffic.SetActive(false);
        taxidriver.SetActive(false);
        pizzaboyOFF.SetActive(true);
        trafficOFF.SetActive(true);
        taxidriverOFF.SetActive(true);
    }
    public void pizzaclick()
    {
        ////
        textSimple.SetActive(false);
        textUrban.SetActive(false);
        soonText.SetActive(true);
        ///
        simplecity1.SetActive(false);
        urbancity1.SetActive(false);
        pizzaboy.SetActive(true);
        pizzaboyOFF.SetActive(false);
        freeride.SetActive(false);
        traffic.SetActive(false);
        taxidriver.SetActive(false);
        freerideOFF.SetActive(true);
        trafficOFF.SetActive(true);
        taxidriverOFF.SetActive(true);
    }
    public void trafficclick()
    {
        ////
        textSimple.SetActive(false);
        textUrban.SetActive(false);
        soonText.SetActive(true);
        ///
        simplecity1.SetActive(false);
        urbancity1.SetActive(false);
        pizzaboy.SetActive(false);
        pizzaboyOFF.SetActive(true);
        freeride.SetActive(false);
        freerideOFF.SetActive(true);
        traffic.SetActive(true); 
        trafficOFF.SetActive(false);
        taxidriver.SetActive(false);
        taxidriverOFF.SetActive(true);
    }
    public void taxiclick()
    {
        ////
        textSimple.SetActive(false);
        textUrban.SetActive(false);
        soonText.SetActive(true);
        ///
        simplecity1.SetActive(false);
        urbancity1.SetActive(false);
        freeride.SetActive(false);
        freerideOFF.SetActive(true);
        pizzaboy.SetActive(false);
        pizzaboyOFF.SetActive(true);
        traffic.SetActive(false);
        trafficOFF.SetActive(true);
        taxidriver.SetActive(true);
        taxidriverOFF.SetActive(false);
    }
}
