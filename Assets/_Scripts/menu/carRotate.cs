using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class carRotate : MonoBehaviour {

    public GameObject car;
    public float speed = 130;

	void Start () {
		
	}
	

	void Update () {
        transform.Rotate(Vector3.up* Time.deltaTime * speed);

    }
}
