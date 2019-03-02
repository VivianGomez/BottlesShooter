using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Reiniciar : MonoBehaviour {

    public float restartDelay = 1f;
    public AudioSource sonido;

    public void OnCollisionEnter(Collision col)
    {
        Invoke("Restart", restartDelay);
    }


    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        sonido.Play();
    }
}
