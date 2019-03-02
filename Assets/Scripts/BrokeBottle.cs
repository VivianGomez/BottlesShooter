using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrokeBottle : MonoBehaviour {

    public AudioSource sonido;


    // Start is called before the first frame update
    void Start()
    {
        sonido = GetComponent<AudioSource>();
    }
    public void OnCollisionEnter(Collision col)
    {
        sonido.Play();
    }
}
