using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CampoFuerza : MonoBehaviour {

	int conteoNotas;
	private AudioClip[] audioNotas;
	private AudioClip sonidoPeye;
	private AudioClip sonidoOuch;

	// Use this for initialization
	void Start () {
		this.conteoNotas = 0;
		this.audioNotas = new AudioClip[4];
		this.sonidoPeye = new Resources.Load<AudioClip>("Sounds/peye");
		this.sonidoPeye = new Resources.Load<AudioClip>("Sounds/ouch");
		for (int i = 0; i < audioNotas.Length; i++)
		{
    		audioNotas[i] = Resources.Load<AudioClip>("Sounds/" + i);
		}
	}

	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerStay2D (Collider2D coll) {
		int tipoNotaCol = coll.gameObject.GetComponent<Nota>().tipo;
		if(Input.GetKey("f")  {
			if(tipoNotaCol == 1){
				this.GetComponent<AudioSource>().PlayOneShot(this.audioNotas[conteoNotas]);
				this.conteoNotas++;
				Destroy(coll.gameObject);
			} else {
				this.GetComponent<AudioSource>().PlayOneShot(this.sonidoPeye);
				this.conteoNotas++;
				Destroy(coll.gameObject);
			}
		}
		if(Input.GetKey("g")  {
			if(tipoNotaCol == 2){
				this.GetComponent<AudioSource>().PlayOneShot(this.audioNotas[conteoNotas]);
				this.conteoNotas++;
				Destroy(coll.gameObject);
			} else {
				this.GetComponent<AudioSource>().PlayOneShot(this.sonidoPeye);
				this.conteoNotas++;
				Destroy(coll.gameObject);
			}
		}
		if(Input.GetKey("h")  {
			if(tipoNotaCol == 3){
				this.GetComponent<AudioSource>().PlayOneShot(this.audioNotas[conteoNotas]);
				this.conteoNotas++;
				Destroy(coll.gameObject);
			} else {
				this.GetComponent<AudioSource>().PlayOneShot(this.sonidoPeye);
				this.conteoNotas++;
				Destroy(coll.gameObject);
			}
		}
		if(Input.GetKey("j")  {
			if(tipoNotaCol == 4){
				this.GetComponent<AudioSource>().PlayOneShot(this.audioNotas[conteoNotas]);
				this.conteoNotas++;
				Destroy(coll.gameObject);
			} else {
				this.GetComponent<AudioSource>().PlayOneShot(this.sonidoPeye);
				this.conteoNotas++;
				Destroy(coll.gameObject);
			}
		}
	} 

	void OnTriggerExit2D (Collider2D coll) {
		this.GetComponent<AudioSource>().PlayOneShot(this.sonidoOuch);
		this.conteoNotas++;
		Destroy(coll.gameObject);
	}
	
}
