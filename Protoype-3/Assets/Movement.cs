using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {
	private float counter=0;


	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		counter += Time.deltaTime;
		//gamePieceArray array = GameObject.Find("Grid").GetComponent<gamePieceArray>();
		if (counter >0.1f){
			if (Input.GetKey("up")){
				if (transform.position.y<=4.5){
					//array.piecesArray[1]=1;
					transform.position=new Vector3(transform.position.x,6.25f, 3);
					counter=0;
				}
			}
			if (Input.GetKey("down")){
				if (transform.position.y>=-2.5){
					transform.position=new Vector3(transform.position.x,-4.25f,3);
					counter=0;
				}
			}
			if (Input.GetKey("left")){
				if (transform.position.x>=-3.5){
					transform.position=new Vector3(-5.25f,transform.position.y,3);
					counter=0;
				}
			}
			if (Input.GetKey("right")){
				if (transform.position.x<=3.5){
					transform.position=new Vector3(5.25f,transform.position.y,3);
					counter=0;
				}
			}
		}
	}
}
