using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class CampoFuerza : MonoBehaviour {

	int conteoNotas;
	private AudioClip[] audioNotas;
	private AudioClip sonidoPeye;
	private AudioClip sonidoOuch;
	private int notaCorrecta;
	private int vidas;
	public Sprite[] luz;
	public Image farol;
	public Image combo;
	bool escudo;
	int iEscudo;
	float y;
	// Use this for initialization
	void Start () {
		this.vidas = 3;
		this.conteoNotas = 0;
		this.audioNotas = new AudioClip[4];
		this.escudo = false;

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
		if (vidas > 0) {
			farol.sprite = luz [vidas - 1];
		} else {
			farol.gameObject.SetActive (false);
			Time.timeScale = 0;
		}

		if(notaCorrecta == 8){
			if (iEscudo < 2) {
				escudo = true;
			} else {
				escudo = false;
				this.notaCorrecta = 0;
				this.iEscudo = 0;
				combo.transform.localPosition = new Vector2 (combo.transform.localPosition.x, -84.3f);
			}
		}

	}

	void OnTriggerStay2D (Collider2D coll) {
		int tipoNotaCol = coll.gameObject.GetComponent<Nota>().tipo;
		if(Input.GetKeyUp("f"))  {
			if(tipoNotaCol == 1){
				teclaCorrecta(coll);
			} else {
				teclaIncorrecta(coll);
			}
		}
		if(Input.GetKeyUp("g"))  {
			if(tipoNotaCol == 2){
				teclaCorrecta(coll);
			} else {
				teclaIncorrecta(coll);
			}
		}
		if(Input.GetKeyUp("h"))  {
			if(tipoNotaCol == 3){
				teclaCorrecta(coll);
			} else {
				teclaIncorrecta(coll);
			}
		}
		if(Input.GetKeyUp("j"))  {
			if(tipoNotaCol == 4){
				teclaCorrecta(coll);
			} else {
				teclaIncorrecta(coll);
			}
		}
	} 

	void OnTriggerExit2D (Collider2D coll) {
		
		this.GetComponent<AudioSource>().PlayOneShot(this.sonidoOuch);
		this.conteoNotas++;
		if(!escudo){
			print ("entre2");
			this.vidas--;
			this.notaCorrecta = 0;
			combo.transform.localPosition = new Vector2 (combo.transform.localPosition.x,-84.3f);
		} else {
			iEscudo++;
		}
		Destroy(coll.gameObject);
	}

	void teclaCorrecta(Collider2D coll)
	{
		this.GetComponent<AudioSource>().PlayOneShot(this.audioNotas[this.conteoNotas]);
		this.conteoNotas++;
		this.notaCorrecta++;
		this.y = combo.transform.localPosition.y + 5.05f ;
		print (y);
		combo.transform.localPosition = new Vector2 (combo.transform.localPosition.x,y);
		Destroy(coll.gameObject);
	}

	void teclaIncorrecta(Collider2D coll) 
	{
		this.GetComponent<AudioSource>().PlayOneShot(this.sonidoPeye);
		this.conteoNotas++;
		if (!escudo) {
			this.vidas--;
			this.notaCorrecta = 0;
			combo.transform.localPosition = new Vector2 (combo.transform.localPosition.x, -84.3f);
		} else {
			iEscudo++;
		}
		Destroy(coll.gameObject);
	}
	
}
