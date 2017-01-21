using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disparo : MonoBehaviour {


	public bool algo;
	public Rigidbody nota;
	public float speed;
	void Start () {
		InvokeRepeating ("lanzaNotas",2f,5f);
	}
	
	// Update is called once per frame
	void Update () {
//		if(algo){
//			Invoke ("lanzaNotas",2f);
//		}
	}

	private void lanzaNotas(){
		Rigidbody instantiatedProjectile = Instantiate(nota,transform.position, transform.rotation ) as Rigidbody;
		instantiatedProjectile.velocity = transform.TransformDirection(new Vector3(speed, 0f,0f));
	}
}
