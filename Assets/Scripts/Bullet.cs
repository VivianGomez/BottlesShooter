using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 40.0f;
    private Rigidbody rb;
    public AudioClip Sonido = null;
    public float Volumen = 1.0f;
    protected Transform Posicion = null;

    // Start is called before the first frame update
    void Start()
    {
        Posicion = transform;
        rb = gameObject.GetComponent<Rigidbody>();
        Destroy(gameObject, 5);
    }

    // Update is called once per frame
    void Update()
    {
        rb.AddForce(transform.forward * speed);
    }

    public void OnCollisionEnter(Collision col)
    {
        if (Sonido) AudioSource.PlayClipAtPoint(Sonido, Posicion.position, Volumen);
        Debug.Log(gameObject.name + " ha colisionado con " + col.gameObject.name);
    }
}
