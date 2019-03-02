using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    public GameObject bullet;
    // Las siguientes son para poder controlar el flujo del disparo
    //( que no se instancie una bala en cada disparo inmediato, sino que haya un espacio
    public float fireRate; 
    private float nextFire;
    public AudioClip Sonido = null;
    public float Volumen = 1.0f;
    protected Transform Posicion = null;

    // Start is called before the first frame update
    void Start()
    {
        Posicion = transform;
    }

        // Update is called once per frame
        void Update()
    {
        //En el Oculus Go PrimaryIndexTrigger es el gatillo delantero
        //Aca resivimos el evento de pulsación del botón
        if (OVRInput.GetDown(OVRInput.Button.PrimaryIndexTrigger) && Time.time > nextFire)
        {
            nextFire = Time.time + fireRate;

            //Crear la bala y  darle la posicion del elemento al que le pertence el presente code
            Instantiate(bullet, gameObject.transform.position, gameObject.transform.rotation);

        }
    }

    public void OnCollisionEnter(Collision col)
    {
        if (Sonido) AudioSource.PlayClipAtPoint(Sonido, Posicion.position, Volumen);
        Debug.Log(gameObject.name + " ha colisionado con " + col.gameObject.name);
    }
}
