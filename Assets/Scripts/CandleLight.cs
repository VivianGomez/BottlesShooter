using UnityEngine;
using System.Collections;

public class CandleLight : MonoBehaviour {
	
	float delay;
	
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update ()
	{
		delay -= Time.deltaTime;
		if (delay > 0.0f) return; 
		
		GetComponent<Light>().color = new Color(1.0f, 0.7f + Mathf.Sin(Time.time*10.0f)*0.15f+0.15f, 0.35f);
		
		delay = 0.05f;
	}
}
