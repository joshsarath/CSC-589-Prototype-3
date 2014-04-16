using UnityEngine;
using System.Collections;

public class Move : MonoBehaviour {

	public GameObject piece;

	// Use this for initialization
	void Start () {
		Instantiate (piece);
	}
	
	// Update is called once per frame
	void Update () {
		/*i will put a timer that will freeze out until all movement is finished.
		 * All movement will be within an if statement testing if timer ==0
		 * after a keypress timer = 1
		 * movement process will go and at end of procedure timer =0
		 */
			if (Input.GetKey ("up")) {
				foreach(GameObject go in GameObject.FindGameObjectsWithTag("Piece")) {
					Game piece= GameObject.Find (go.name).GetComponent<Game>();
					if (piece.transform.position.y<11){
						piece.upspeed=.5f;
					}
				}
			}
		if (Input.GetKey ("down")) {
			foreach(GameObject go in GameObject.FindGameObjectsWithTag("Piece")) {
				Game piece= GameObject.Find (go.name).GetComponent<Game>();
				if (piece.transform.position.y>3){
					piece.upspeed=-.5f;
				}
			}
		}
		if (Input.GetKey ("right")) {
			foreach(GameObject go in GameObject.FindGameObjectsWithTag("Piece")) {
				Game piece= GameObject.Find (go.name).GetComponent<Game>();
				if (piece.transform.position.x<5){
					piece.sidespeed=.5f;
				}
			}
		}
		if (Input.GetKey ("left")) {
			foreach(GameObject go in GameObject.FindGameObjectsWithTag("Piece")) {
				Game piece= GameObject.Find (go.name).GetComponent<Game>();
				if (piece.transform.position.x>-4){
					piece.sidespeed=-.5f;
				}
			}
		}
	
	}
}
