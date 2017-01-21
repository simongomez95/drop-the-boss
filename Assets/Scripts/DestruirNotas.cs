using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestruirNotas : MonoBehaviour {


	private GameObject fa;
	private GameObject re;
	private GameObject mi;
	private GameObject la;
	public int points;
	public bool destruirFa;
	public bool destruirRe;
	public bool destruirMi;
	public bool destruirLa;

	public static DestruirNotas instancia;

	void Awake (){
		instancia = this;
	}
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyUp("f")){
			fa = GameObject.FindWithTag ("fa");
			if (fa != null) {
				print ("entre");
				if(!destruirFa){
					fa.GetComponent<Rigidbody> ().AddForce (new Vector3(Disparo.instancia.speed*-100,0f,0f));
					fa.tag = "Untagged";
					points++;
				}
			} else {
				points = 0;
				destruirLa = true;
				destruirMi = true;
				destruirRe = true;
				print ("huy que bruto");
			}
		}else if(Input.GetKeyUp("g")){
			la = GameObject.FindWithTag  ("la");
			if (la != null) {
				if(!destruirLa){
					Destroy (la);
					points++;
				}
			} else {
				destruirFa = true;
				destruirMi = true;
				destruirRe = true;
			}
		}else if(Input.GetKeyUp("h")){
			re = GameObject.FindWithTag  ("re");
			if (re != null) {
				if(!destruirRe){
					Destroy (re);
					points++;
				}
			} else {
				destruirLa = true;
				destruirMi = true;
				destruirFa = true;
			}
		} else 	if(Input.GetKeyUp("j")){
			mi = GameObject.FindWithTag  ("mi");
			if (mi != null) {
				if(!destruirMi){
					Destroy (mi);
					points++;
				}
			} else {
				destruirLa = true;
				destruirFa = true;
				destruirRe = true;
			}
		}
	}
}
