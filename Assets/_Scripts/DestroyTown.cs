using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyTown : MonoBehaviour {

    public float timer, floatpower;
	void Start () {

	}
	

	void Update () {
        timer = (timer - floatpower); //* Time.deltaTime;
        if (timer <= 0)
        {
            //Destroy(this.gameObject);
            
        }
	}
    private void OnBecameInvisible()
    {
        gameObject.SetActive(false);
        print("WOW");
    }
}
