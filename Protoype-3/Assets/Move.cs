using UnityEngine;
using System.Collections;

public class Move : MonoBehaviour {

	public GameObject piece;
	private float time=0;
	private float timeDelay=3f;

	// Use this for initialization
	void Start () {
		Instantiate (piece);
	}
	
	// Update is called once per frame
	void Update () {
		//if (time==0){
			if (Input.GetKey ("up")) {
				//Debug.Log ("poop");
				time=timeDelay;
				foreach(GameObject go in GameObject.FindGameObjectsWithTag("Piece")) {
					Game piece= GameObject.Find (go.name).GetComponent<Game>();
					Debug.Log("worked");
					if (piece.transform.position.y<14){
						piece.upspeed=.5f;
					}
				}
			}
		//}
		//time -= Time.deltaTime;
	}
}
