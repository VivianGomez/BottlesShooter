using UnityEngine;
using System.Collections;

public class TriggerSoundTouch : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void OnMouseDown() {
		if (gameObject.GetComponent<AudioSource>() != null) gameObject.GetComponent<AudioSource>().Play();
    }
}
