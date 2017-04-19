using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RocketCollide : MonoBehaviour {

	void OnTriggerEnter2D(Collider2D other){
		if (other.transform.tag == "Asteroid") {
			Destroy (other.gameObject);
			Destroy (this.gameObject);
		}
	}
}
