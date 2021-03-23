using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class startgame : MonoBehaviour {

    public GameObject map, buy, speed, s1, s2,s3, handling, had1, had2, had3, coinimg, cointext;
    public GameObject camStart, camGame, Button;
    public Animation cam; 
   

	void Start () {
        map.SetActive(false);
        buy.SetActive(false);
        speed.SetActive(false);
        s1.SetActive(false);
        s2.SetActive(false);
        s3.SetActive(false);
        handling.SetActive(false);
        had1.SetActive(false);
        had2.SetActive(false);
        had3.SetActive(false);
        coinimg.SetActive(false);
        cointext.SetActive(false);
        camGame.SetActive(false);
    }
	
	
	public void cameraGo()
    {
        cam.Play();
        
    }
}
