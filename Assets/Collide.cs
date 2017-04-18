using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collide : MonoBehaviour {

	public int lives;
	public GameObject[] liveGraph;

	void OnTriggerEnter2D(Collider2D other){
		if(other.transform.tag == "Asteroid"){
			if (lives > 0) {
				lives--;
				Debug.Log (lives);
			}
		}
	}

	void Update(){
		if(lives == 3){
			liveGraph [0].GetComponent<SpriteRenderer> ().enabled = true;
			liveGraph [1].GetComponent<SpriteRenderer> ().enabled = true;
			liveGraph [2].GetComponent<SpriteRenderer> ().enabled = true;
		}
		else if(lives == 2){
			liveGraph [0].GetComponent<SpriteRenderer> ().enabled = true;
			liveGraph [1].GetComponent<SpriteRenderer> ().enabled = true;
			liveGraph [2].GetComponent<SpriteRenderer> ().enabled = false;
		}
		else if(lives == 1){
			liveGraph [0].GetComponent<SpriteRenderer> ().enabled = true;
			liveGraph [1].GetComponent<SpriteRenderer> ().enabled = false;
			liveGraph [2].GetComponent<SpriteRenderer> ().enabled = false;
		}
		else if(lives == 0){
			liveGraph [0].GetComponent<SpriteRenderer> ().enabled = false;
			liveGraph [1].GetComponent<SpriteRenderer> ().enabled = false;
			liveGraph [2].GetComponent<SpriteRenderer> ().enabled = false;
		}
	}

}
