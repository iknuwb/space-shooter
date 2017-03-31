using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour {

	public GameObject rocket;
	public float timer;
	float timeLeft=0;
	public Transform startRocket;
	public Transform player;



	// Update is called once per frame
	void FixedUpdate () {
		if(Input.GetKey(KeyCode.Space))
		{
			if (timeLeft > timer) {
				GameObject rocketShot = Instantiate (rocket,new Vector3(startRocket.position.x,startRocket.position.y,startRocket.position.z),Quaternion.identity);
				rocketShot.transform.rotation = player.rotation;
				rocketShot.GetComponent<Rigidbody2D> ().AddForce ((startRocket.position-player.position)*5f, ForceMode2D.Impulse);
				timeLeft = 0;
			} else {
				timeLeft += Time.deltaTime;
			}
		}
	}
}
