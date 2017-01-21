using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nota : MonoBehaviour {

	public int sprite;
	public int id;
	public Sprite sprite1;
	public Sprite sprite2;
	public Sprite sprite3;
	public Sprite sprite4;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void setSprite(int sprite) {
		switch(sprite) {
			case 1: {
				this.GetComponent<SpriteRenderer>().sprite = this.sprite1;
				break;
			}
			case 2: {
				this.GetComponent<SpriteRenderer>().sprite = this.sprite2;
				break;
			}
			case 3: {
				this.GetComponent<SpriteRenderer>().sprite = this.sprite3;
				break;
			}
			case 4: {
				this.GetComponent<SpriteRenderer>().sprite = this.sprite4;
				break;
			}
		}
	}
}
