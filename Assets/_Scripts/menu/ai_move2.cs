using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ai_move2 : MonoBehaviour {

    public int speed, rand;
    public float timer;
    public GameObject car1, car2, car3, car4, car5, car6;
    private void Start()
    {
        rand = Random.Range(0, 6);
      
    }

    void Update()
    {
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
            car2.transform.Translate(Vector3.right * speed * Time.deltaTime);
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
            car4.transform.Translate(Vector3.right * speed * Time.deltaTime);
            if (timer <= 0)
            {
                timer = 4;
                rand = 4;
            }
        }
        if (rand == 4)
        {
            car5.transform.Translate(Vector3.right * speed * Time.deltaTime);
            if (timer <= 0)
            {
                timer = 5;
                rand = 5;
            }
        }
        if (rand == 5)
        {
            car6.transform.Translate(Vector3.forward * speed * Time.deltaTime);
            if (timer <= 0)
            {
                timer = 4;
                rand = 0;
            }
        }

    }
}
