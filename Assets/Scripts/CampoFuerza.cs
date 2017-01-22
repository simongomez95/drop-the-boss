using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using MidiJack;
public class CampoFuerza : MonoBehaviour {

	int conteoNotas;
	private AudioClip[] audioNotas;
	private AudioClip sonidoPeye;
	private AudioClip sonidoOuch;
	private AudioClip pista;
	private int notaCorrecta;
	private int vidas;
	public Sprite[] luz;
	public Image farol;
	public Image combo;
	bool escudo;
	public int iEscudo;
	float y;
	public Image restar;
	private GameObject[] notasDentro;

	public GameObject lobito;


	// Use this for initialization
	void Start () {
		
	}

	void Awake() {
		notasDentro = new GameObject[2];
		iEscudo = 0;
		this.vidas = 3;
		this.conteoNotas = 0;
		this.audioNotas = new AudioClip[32];
		this.escudo = false;

		// Cargar sonidos de fail
		this.sonidoPeye =  Resources.Load<AudioClip>("Sounds/Nota_erronea");

		// Cargar todas las notas
		for (int i = 0; i < audioNotas.Length; i++) {
			int num = i+1;
    		audioNotas[i] = Resources.Load<AudioClip>("Sounds/Nota" + num);
		}
	}

	// Update is called once per frame
	void Update () {
		for(int i = 0; i < 100; i++) {
			if(MidiMaster.GetKey(i) > 0) {
			Debug.Log(MidiMaster.GetKey(i));
			Debug.Log(i);
		}		
		}
		
		if (vidas > 0) {
			farol.sprite = luz [vidas - 1];
		} else {
			farol.gameObject.SetActive (false);
			Time.timeScale = 0;
			restar.gameObject.SetActive (true);
		}

		if(notaCorrecta == 8 || escudo){
			if (iEscudo < 2) {
				escudo = true;
				lobito.SetActive(true);
			} else {
				escudo = false;
				this.notaCorrecta = 0;
				this.iEscudo = 0;
				combo.transform.localPosition = new Vector2 (combo.transform.localPosition.x, -28.7f);
				lobito.SetActive(false);
			}
		}

	}

	void OnTriggerEnter2D (Collider2D coll) {
		if(notasDentro[0] != null) {
			notasDentro[1] = coll.gameObject;
		} else {
			notasDentro[0] = coll.gameObject;
		}
	}

	void OnTriggerStay2D (Collider2D coll) {
		int tipoNotaCol = coll.gameObject.GetComponent<Nota>().tipo;
		if((Input.GetKeyDown("f")) || (MidiMaster.GetKeyDown(36)))  {
			if(tipoNotaCol == 1){
				teclaCorrecta(coll);
			} else {
				teclaIncorrecta(coll);
			}
		}
		else if((Input.GetKeyDown("g")) || (MidiMaster.GetKeyDown(38)))  {
			if(tipoNotaCol == 2){
				teclaCorrecta(coll);
			} else {
				teclaIncorrecta(coll);
			}
		}
		else if((Input.GetKeyDown("h")) || (MidiMaster.GetKeyDown(40)))  {
			if(tipoNotaCol == 3){
				teclaCorrecta(coll);
			} else {
				teclaIncorrecta(coll);
			}
		}
		else if((Input.GetKeyDown("j")) || (MidiMaster.GetKeyDown(41)))  {
			if(tipoNotaCol == 4){
				teclaCorrecta(coll);
			} else {
				teclaIncorrecta(coll);
			}
		}
	} 

	void OnTriggerExit2D (Collider2D coll) {
		
		this.GetComponent<AudioSource>().PlayOneShot(this.sonidoPeye);
		this.conteoNotas++;
		if(!escudo){
			this.vidas--;
			this.notaCorrecta = 0;
			combo.transform.localPosition = new Vector2 (combo.transform.localPosition.x,-28.7f);
		} else {
			iEscudo++;
		}
		Destroy(coll.gameObject);
		notasDentro[0] = notasDentro[1];
		notasDentro[1] = null;
	}

	void teclaCorrecta(Collider2D coll)
	{
		this.GetComponent<AudioSource>().PlayOneShot(this.audioNotas[this.conteoNotas]);
		this.conteoNotas++;
		this.notaCorrecta++;
		this.y = combo.transform.localPosition.y + 5.35f;
		if(!escudo){
			combo.transform.localPosition = new Vector2 (combo.transform.localPosition.x,y);	
		}

		Destroy(coll.gameObject);
		notasDentro[0] = notasDentro[1];
		notasDentro[1] = null;
	}

	void teclaIncorrecta(Collider2D coll) 
	{
		this.GetComponent<AudioSource>().PlayOneShot(this.sonidoPeye);
		this.conteoNotas++;
		if (!escudo) {
			this.vidas--;
			this.notaCorrecta = 0;
			combo.transform.localPosition = new Vector2 (combo.transform.localPosition.x, -28.7f);
		} else {
			iEscudo++;
		}
		Destroy(coll.gameObject);
		notasDentro[0] = notasDentro[1];
		notasDentro[1] = null;
	}
	
}
