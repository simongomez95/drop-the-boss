using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.SceneManagement;
using UnityEngine.SceneManagement;
public class lvls : MonoBehaviour {

	int lvl;
	// Use this for initialization
	void Start () {
		lvl = SceneManager.GetActiveScene ().buildIndex;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void nextLvl(){
		EditorSceneManager.LoadScene (lvl+1);
	}
}
