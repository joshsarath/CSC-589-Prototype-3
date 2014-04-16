using UnityEngine;
using System.Collections;

public class StopObject : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

	}
	void OnTriggerEnter (Collider other){
		Debug.Log ("stuff");
		Game piece = other.gameObject.GetComponent<Game> ();
		piece.upspeed = 0;
		piece.sidespeed = 0;
	}
}
