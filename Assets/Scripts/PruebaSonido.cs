using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PruebaSonido : MonoBehaviour {

	private AudioClip[] audioNotas;
	// Use this for initialization
	void Start () {
		this.audioNotas = new AudioClip[32];
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKey("f"))  {
			this.GetComponent<AudioSource>().PlayOneShot(this.audioNotas[0]);
		}
	}
}
