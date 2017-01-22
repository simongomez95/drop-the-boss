using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class progreso : MonoBehaviour {

	float tiempo;
	public float vel;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		tiempo += Time.deltaTime;
		if (tiempo < 82.1f) {
			transform.position = new Vector2 (transform.position.x + vel * Time.deltaTime, transform.position.y);
		} else {
			transform.position = new Vector2 (transform.position.x, transform.position.y);
		}

	}
}
