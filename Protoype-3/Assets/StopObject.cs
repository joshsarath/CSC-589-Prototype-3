using UnityEngine;
using System.Collections;

public class StopObject : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnTriggerEnter(Collider other){
		Game piece = other.GetComponent<Game> ();
		piece.upspeed = 0f;
		piece.sidespeed = 0f;
	}
}
