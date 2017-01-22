using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class progreso : MonoBehaviour {

	float tiempo;
	public float vel;
	public GameObject silbon;
	public GameObject creditos;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		tiempo += Time.deltaTime;
		print (tiempo);
		if (tiempo < 82.1f) {
			transform.position = new Vector3 (transform.position.x + vel * Time.deltaTime, transform.position.y, -1f);
		} else {
			transform.position = new Vector3 (transform.position.x, transform.position.y, -1f);
			creditos.SetActive(true);
		}
		if(tiempo > 32.2f) {
			silbon.SetActive(true);
		}

	}
}
