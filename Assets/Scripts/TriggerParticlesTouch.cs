using UnityEngine;
using System.Collections;

public class TriggerParticlesTouch : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void OnMouseDown() {
		gameObject.GetComponent<ParticleSystem>().Stop();
		gameObject.GetComponent<ParticleSystem>().Play();
		if (gameObject.GetComponent<AudioSource>() != null) gameObject.GetComponent<AudioSource>().Play();
    }
}
