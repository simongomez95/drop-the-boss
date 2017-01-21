using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disparo : MonoBehaviour {


	public bool algo;
	public GameObject nota;
	public float speed;
	private float timer;
	private List<int> listaTiempos;
	private Dictionary<int, int> notas;
	public static Disparo instancia;

	void Awake(){
		instancia = this;
	}

	void Start () {
		this.notas = new Dictionary<int, int>();
		notas.Add(2, 1);
		notas.Add(20, 2);
		notas.Add(3, 3);
		notas.Add(10, 4);
		listaTiempos = new List<int>(notas.Keys);
		listaTiempos.Sort();
		this.timer = 0;
	}
	
	// Update is called once per frame
	void Update () {
		timer += Time.deltaTime;
		foreach (int tiempoNota in listaTiempos)
		{
			if((this.timer - 0.05 < tiempoNota ) && (this.timer + 0.05 > tiempoNota)) {
				lanzaNotas(this.notas[tiempoNota]);
				listaTiempos.Remove(tiempoNota);
			}
		}
	}

	private void lanzaNotas(int tipoNota){
		GameObject instantiatedProjectile = Instantiate(nota,transform.position, transform.rotation ) as GameObject;
		Nota scriptNota = (Nota) instantiatedProjectile.GetComponent(typeof(Nota));
		scriptNota.setTipo(tipoNota);
	}
}
