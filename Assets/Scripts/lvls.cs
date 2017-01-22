using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.SceneManagement;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class lvls : MonoBehaviour {

	int lvl;
	public Image tuto;
	bool close = false;
	// Use this for initialization
	void Start () {
		Time.timeScale = 1;
		lvl = SceneManager.GetActiveScene ().buildIndex;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void nextLvl(){
		EditorSceneManager.LoadScene (lvl+1);
	}

	public void tutorial(){
		close = !close;
		if (close) {
			tuto.gameObject.SetActive (true);	
		} else {
			tuto.gameObject.SetActive (false);
		}

	}

	public void restart(){
		tuto.gameObject.SetActive (false);
		SceneManager.LoadScene (lvl);

	}

	public void menu(){
		SceneManager.LoadScene (0);
	}
}
