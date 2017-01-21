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
	public int speed;
	private Rigidbody rb;

	// Use this for initialization
	void Start () {
		
	}

	void Awake() {
		rb = this.GetComponent<Rigidbody>();
		rb.velocity = transform.TransformDirection(new Vector3(speed, 0f,0f));
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void setSprite(int sprite) {
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
