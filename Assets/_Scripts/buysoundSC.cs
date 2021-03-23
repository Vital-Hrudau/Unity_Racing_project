using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buysoundSC : MonoBehaviour {

    public static buysoundSC Intance { set; get; }

    private void Start()
    {
        Intance = this;
        DontDestroyOnLoad(gameObject);
    }
}
