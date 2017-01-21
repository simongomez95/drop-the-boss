using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disparo : MonoBehaviour {


	public bool algo;
	public Rigidbody nota;
	public float speed;
	private float timer;
	private List<int> listaTiempos;
	public static Disparo instancia;

	void Awake(){
		instancia = this;
	}
	void Start () {
		Dictionary<int, string> notas = new Dictionary<int, string>();
		notas.Add(2, "nota1");
		notas.Add(20, "nota2");
		notas.Add(3, "nota3");
		notas.Add(10, "nota4");
		listaTiempos = new List<int>(notas.Keys);
		listaTiempos.Sort();
		this.timer = 0;
	}
	
	// Update is called once per frame
	void Update () {
		timer += Time.deltaTime;
		foreach (int tiempoNota in listaTiempos)
		{
			Debug.Log(this.timer);
			Debug.Log((this.timer < tiempoNota + 1/2) && (this.timer > tiempoNota - 1/2));
			if((this.timer - 0.1 < tiempoNota ) && (this.timer + 0.1 > tiempoNota)) {
				lanzaNotas();
				listaTiempos.Remove(tiempoNota);
			}
		}
	}

	private void lanzaNotas(){
		Rigidbody instantiatedProjectile = Instantiate(nota,transform.position, transform.rotation ) as Rigidbody;
		instantiatedProjectile.velocity = transform.TransformDirection(new Vector3(speed, 0f,0f));
	}
}
