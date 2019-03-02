using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BW : MonoBehaviour {



    // Update is called once per frame

    public void OnCollisionEnter(Collision col)
    {
       
        GetComponent<BreakableWindow>().breakWindow();
    }
}
