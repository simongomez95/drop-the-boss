using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disparo : MonoBehaviour {


	public bool algo = true;
	public Rigidbody nota;
	public float speed;
	public float tiempo;
	void Start () {
		InvokeRepeating ("lanzaNotas",2f,5f);

	}
	
	// Update is called once per frame
	void Update () {
//		tiempo += Time.deltaTime;
//		if(tiempo > 5.5f && tiempo < 5.6f){
//			if(algo){
//				algo = false;
//				Invoke ("lanzaNotas",0.1f);
//			}
//		}
	}

	private void lanzaNotas(){
		Rigidbody instantiatedProjectile = Instantiate(nota,transform.position, transform.rotation ) as Rigidbody;
		instantiatedProjectile.velocity = transform.TransformDirection(new Vector3(speed, 0f,0f));
	}
}
