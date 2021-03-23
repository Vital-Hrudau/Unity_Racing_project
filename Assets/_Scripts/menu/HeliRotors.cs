using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeliRotors : MonoBehaviour {

    public GameObject rotor1, rotor2, body;
    public int speed1, speed2, speedBody;
    public int rand;


	void Start () {
        rand = Random.Range(0, 3);
		
	}
	
	
	void Update () {
        if (rand == 1)
        {
            rotor1.transform.Rotate(Vector3.up * Time.deltaTime * speed1);
            rotor2.transform.Rotate(Vector3.right * Time.deltaTime * speed2);
            gameObject.transform.Translate(0, 0, 1 * speedBody * Time.deltaTime);
            body.transform.TransformDirection(Vector3.forward);
        }
	
    }
}
