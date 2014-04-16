using UnityEngine;
using System.Collections;

public class Game : MonoBehaviour {

	public float upspeed;
	public float sidespeed;
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		transform.position += new Vector3 (sidespeed, upspeed, 0);
	}
	void onTriggerEnter(Collider other){
		/*
		 * if other is a wall => no movement
		 * 		if self.value== other.value=> combine
		 * 			destroy other
		 * 			change self (value *= 2;)
		 * 		else (xspeed,yspeed=0;
		 * 
		 */
		Debug.Log ("hit");
		if (other.name == "Wall") {
			upspeed=0;
			sidespeed=0;
		}
		/*
		 * if other.name == piece(clone)
		 * if tag==tag of self
		 * 		new tag=tag*2
		 * 		new material
		 * 		Destroy(gameObject.other)
		 */ 

	}
}
