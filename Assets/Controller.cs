using UnityEngine;
using System.Collections;

public class Controller : MonoBehaviour {

	public GameObject player;
	public Rigidbody2D playerPhysics;
	public Transform playerUp;


	public int lives;


	// Use this for initialization
	void Start () {
		//playerPhysics=player.GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		if(Input.GetKey(KeyCode.UpArrow))
		{
			playerPhysics.AddForce((playerUp.position-player.transform.position)*0.5f,ForceMode2D.Impulse);
			playerPhysics.velocity = Vector3.ClampMagnitude(playerPhysics.velocity, 2f);
		}

		if(Input.GetKey(KeyCode.DownArrow))
		{
			//playerPhysics.AddForce(-playerUp.position,ForceMode2D.Impulse);
			//if(playerPhysics.velocity.magnitude > 1.5f){
			//	playerPhysics.velocity = Vector3.ClampMagnitude(playerPhysics.velocity, 1.5f);
			//}
		}

		if(Input.GetKey(KeyCode.LeftArrow))
		{
			player.transform.Rotate(new Vector3(player.transform.rotation.x,player.transform.rotation.y,player.transform.rotation.z+ 5)*100*Time.deltaTime);
		}
		
		if(Input.GetKey(KeyCode.RightArrow))
		{
			player.transform.Rotate(new Vector3(player.transform.rotation.x,player.transform.rotation.y,player.transform.rotation.z-5)*100*Time.deltaTime);
		}
	}
}
