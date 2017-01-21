using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CampoFuerza : MonoBehaviour {

	int conteoNotas;
	private AudioClip[] audioNotas;
	private AudioClip sonidoPeye;
	private AudioClip sonidoOuch;
	private int vidas;

	// Use this for initialization
	void Start () {
		this.vidas = 3;
		this.conteoNotas = 0;
		this.audioNotas = new AudioClip[4];

		// Cargar sonidos de fail
		this.sonidoPeye =  Resources.Load<AudioClip>("Sounds/peye");
		this.sonidoPeye =  Resources.Load<AudioClip>("Sounds/ouch");

		// Cargar todas las notas
		for (int i = 0; i < audioNotas.Length; i++) {
    		audioNotas[i] = Resources.Load<AudioClip>("Sounds/" + i);
		}
	}

	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerStay2D (Collider2D coll) {
		int tipoNotaCol = coll.gameObject.GetComponent<Nota>().tipo;
		if(Input.GetKey("f"))  {
			if(tipoNotaCol == 1){
				teclaCorrecta();
			} else {
				teclaIncorrecta();
			}
		}
		if(Input.GetKey("g"))  {
			if(tipoNotaCol == 2){
				teclaCorrecta();
			} else {
				teclaIncorrecta();
			}
		}
		if(Input.GetKey("h"))  {
			if(tipoNotaCol == 3){
				teclaCorrecta();
			} else {
				teclaIncorrecta();
			}
		}
		if(Input.GetKey("j"))  {
			if(tipoNotaCol == 4){
				teclaCorrecta();
			} else {
				teclaIncorrecta();
			}
		}
	} 

	void OnTriggerExit2D (Collider2D coll) {
		this.GetComponent<AudioSource>().PlayOneShot(this.sonidoOuch);
		this.conteoNotas++;
		this.vidas--;
		Destroy(coll.gameObject);
	}

	void teclaCorrecta()
	{
		this.GetComponent<AudioSource>().PlayOneShot(this.audioNotas[this.conteoNotas]);
		this.conteoNotas++;
		Destroy(coll.gameObject);
	}

	void teclaIncorrecta() 
	{
		this.GetComponent<AudioSource>().PlayOneShot(this.sonidoPeye);
		this.conteoNotas++;
		this.vidas--;
		Destroy(coll.gameObject);
	}
	
}
