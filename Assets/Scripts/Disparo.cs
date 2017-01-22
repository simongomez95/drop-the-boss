using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disparo : MonoBehaviour {


    public bool algo;
    public GameObject nota;
    public float speed;
    private float timer;
    private List<double> listaTiempos;
    private Dictionary<double, int> notas;
    public static Disparo instancia;

    public Animator animSilbon;

    void Awake(){
        instancia = this;
    }

    void Start () {
        this.notas = new Dictionary<double, int>();
        notas.Add(04.375, 2);
        notas.Add(05.306, 1);
        notas.Add(06.205, 4);
        notas.Add(07.123, 2);
        notas.Add(11.603, 1);
        notas.Add(12.484, 2);
        notas.Add(13.192, 3);
        notas.Add(13.479, 2);
        notas.Add(18.961, 1);
        notas.Add(19.890, 2);
        notas.Add(20.906, 4);
        notas.Add(21.784, 3);
        notas.Add(26.231, 3);
        notas.Add(27.157, 4);
        notas.Add(27.812, 1);
        notas.Add(28.120, 2);
        notas.Add(47.750, 2);
        notas.Add(48.187, 3);
        notas.Add(48.641, 1);
        notas.Add(49.103, 3);
        notas.Add(54.676, 2);
        notas.Add(54.909, 3);
        notas.Add(55.219, 1);
        notas.Add(55.473, 2);
        notas.Add(61.527, 1);
        notas.Add(61.989, 2);
        notas.Add(62.142, 4);
        notas.Add(62.486, 2);
        notas.Add(68.365, 1);
        notas.Add(68.902, 4);
        notas.Add(69.190, 3);
        notas.Add(70.818, 2);
        listaTiempos = new List<double>(notas.Keys);
        listaTiempos.Sort();
        this.timer = 0;
    }
    
    // Update is called once per frame
    void Update () {
        timer += Time.deltaTime;
        foreach (double tiempoNota in listaTiempos)
        {
            if((this.timer - 0.05 < tiempoNota ) && (this.timer + 0.05 > tiempoNota)) {
                lanzaNotas(this.notas[tiempoNota]);
                listaTiempos.Remove(tiempoNota);
            } else {
                animSilbon.SetTrigger("yanotocando");
            }
        }
    }

    private void lanzaNotas(int tipoNota){
        animSilbon.SetTrigger("tocando");
        GameObject instantiatedProjectile = Instantiate(nota,transform.position, transform.rotation ) as GameObject;
        Nota scriptNota = (Nota) instantiatedProjectile.GetComponent(typeof(Nota));
        scriptNota.setTipo(tipoNota);
    }
}
