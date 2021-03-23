using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class crashsound : MonoBehaviour
{

    public AudioSource crash;

    private void OnCollisionEnter(Collision collision)
    { crash.Play();}
}
