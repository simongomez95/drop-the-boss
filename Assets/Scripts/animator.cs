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

		if(Input.GetKeyDown("f") || Input.GetKeyDown("g") || Input.GetKeyDown("h") || Input.GetKeyDown("j")){
			anim.SetInteger ("animacion",1);	
		}

		if(Input.GetKeyUp("f") || Input.GetKeyUp("g") || Input.GetKeyUp("h") || Input.GetKeyUp("k")){
			anim.SetInteger ("animacion",2);
		}

		if(!Input.anyKey){
			anim.SetInteger ("animacion",0);
		}
	}
}
