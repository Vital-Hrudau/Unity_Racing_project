using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ai_move : MonoBehaviour {

    public int speed, rand;
    public float timer;
    public GameObject car1, car2, car3, car4;
    private void Start()
    {
        rand = Random.Range(0,4);
        timer = 4;
    }

    void Update () {
        timer -= 0.01f;
        
        if (rand == 0)
        {
            car1.transform.Translate(Vector3.right * speed * Time.deltaTime);
            if (timer <= 0)
            {
                timer = 4;
                rand = 1;
            }
        }
        if (rand == 1)
        {
            car2.transform.Translate(Vector3.back* speed * Time.deltaTime);
            if (timer <= 0)
            {
                timer = 4;
                rand = 2;
            }
        }
        if (rand == 2)
        {
            car3.transform.Translate(Vector3.right * speed * Time.deltaTime);
            if (timer <= 0)
            {
                timer = 4;
                rand = 3;
            }
        }
        if (rand == 3)
        {
            car4.transform.Translate(Vector3.forward * speed * Time.deltaTime);
            if (timer <= 0)
            {
                timer = 4;
                rand = 0;
            }
        }

    }
}
