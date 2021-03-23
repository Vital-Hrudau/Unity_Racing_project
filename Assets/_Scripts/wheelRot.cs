using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wheelRot : MonoBehaviour {

    public GameObject wheel;
    public int speed;


	void Start () {
		
	}
	
	
	void Update () {
        transform.Rotate(Vector3.forward * Time.deltaTime * speed);
    }
}
