using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animator : MonoBehaviour {
	public Animator anim;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKeyDown ("f") || Input.GetKeyDown ("g") || Input.GetKeyDown ("h") || Input.GetKeyDown ("j")) {
			anim.SetTrigger ("flautaUp");
		}

		if (Input.GetKeyUp ("f") || Input.GetKeyUp ("g") || Input.GetKeyUp ("h") || Input.GetKeyUp ("j")) {
			StartCoroutine (Esperar ());
			anim.SetTrigger ("flautaDown");
			StartCoroutine (Esperar ());
			anim.SetTrigger ("corrida");
			
		}

	}

	IEnumerator Esperar() {
		print(Time.time);
		yield return new WaitForSeconds(0.5f);
		print(Time.time);
	}
}
