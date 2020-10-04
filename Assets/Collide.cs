using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collide : MonoBehaviour {

	public int lives;
	public GameObject life1 , lif2 ,life3 ,gameover , player ,metoids;

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
			life1.SetActive(true);
			lif2.SetActive(true);
			life3.SetActive(true);
		}
		else if(lives == 2){
			life1.SetActive(true);
			lif2.SetActive(true);
			life3.SetActive(false);
		}
		else if(lives == 1){
			life1.SetActive(true);
			lif2.SetActive(false);
			life3.SetActive(false);
		}
		else if(lives == 0){
			life1.SetActive(false);
			lif2.SetActive(false);
			life3.SetActive(false);
			gameover.SetActive(true);
			metoids.SetActive(false);
			player.SetActive(false);
		}
	}

}
