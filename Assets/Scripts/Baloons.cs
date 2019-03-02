using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Baloons : MonoBehaviour {

    public AudioSource sonido;

    void Start()
    {
        sonido = GetComponent<AudioSource>();
    }

    public void OnCollisionEnter(Collision col)
    {
        Destroy(gameObject);
        sonido.Play();
    }
}
