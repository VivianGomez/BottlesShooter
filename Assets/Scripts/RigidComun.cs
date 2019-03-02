using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RigidComun : MonoBehaviour {

    public void OnCollisionEnter(Collision col)
    {
        Debug.Log(gameObject.name + " ha colisionado con " + col.gameObject.name);
    }
}
