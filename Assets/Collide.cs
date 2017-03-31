using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collide : MonoBehaviour {

	public int lives;

	void OnTriggerEnter2D(Collider2D other){
		if(other.transform.tag == "Asteroid"){
			if (lives > 0) {
				lives--;
				Debug.Log (lives);
			}
		}
	}

}
