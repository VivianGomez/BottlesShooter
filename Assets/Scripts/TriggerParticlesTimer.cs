using UnityEngine;
using System.Collections;

public class TriggerParticlesTimer : MonoBehaviour {
	
	public float delay;
	public float interval;
	
	private float t;
	
	// Use this for initialization
	void Start () {
		t = delay;
	}
	
	// Update is called once per frame
	void Update () {
		t -= Time.deltaTime;
		if (t > 0.0f) return; 
		gameObject.GetComponent<ParticleSystem>().Stop();
		gameObject.GetComponent<ParticleSystem>().Play();
		if (gameObject.GetComponent<AudioSource>() != null) gameObject.GetComponent<AudioSource>().Play();
		t = interval;
    }
}
