﻿using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {
	private float counter=0;
	public GameObject spawnObject;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		gamePieceArray pieces = (gamePieceArray)GameObject.Find("Grid").gameObject.GetComponent("gamePieceArray");
		pieces.array [3, 0] = 1; 
		counter += Time.deltaTime;
		//gamePieceArray array = GameObject.Find("Grid").GetComponent<gamePieceArray>();
		if (Input.GetKey ("space")) {
			for(int i=0; i<4; i++){
				Debug.Log(i+":"+pieces.array[i,0]+","+pieces.array[i,1]+","+pieces.array[i,2]+","+pieces.array[i,3]);
			}
		}
		if (counter >0.1f){
			if (Input.GetKey("up")){
				if (transform.position.y<=3.5){
					updateArrayUp(pieces);
					counter=0;
				}
			}
			if (Input.GetKey("down")){
				if (transform.position.y>=-3.5){
					transform.position=new Vector3(transform.position.x,1.25f,transform.position.z);
					counter=0;
				}
			}
			if (Input.GetKey("left")){
				if (transform.position.x>=-3.5){
					transform.position=new Vector3(-5.25f,transform.position.y,transform.position.z);
					counter=0;
				}
			}
			if (Input.GetKey("right")){
				if (transform.position.x<=3.5){
					transform.position=new Vector3(5.25f,transform.position.y,transform.position.z);
					counter=0;
				}
			}
		}
	}
	int computePositionVert(){
		int value = (int)((transform.position.x + 5.25) / 3.5);
		return value;
	}
	int computePostionHort(){
		int value = (int)(3 - (transform.position.y - 1.25) / 3.5);
		return value;
	}
	void updateArrayUp(gamePieceArray pieces){
		/* int i=((position.x+5.25)/3.5)
		 * int j=((poistion.y-1.75)/3.5)
		 * 		test each vertical of array pieces.array[i,3]&&[i,2]&&[i,1]&&[i,3]
		 * if all empty= new position equals top
		 * if position above == self==> combime()
		 * while position above!= self move to j+1
		 */

		int column = computePositionVert ();
		int row = computePostionHort ();
		if (row>0){//make sure not on top row
			if (0==pieces.array[row-1,column]){//tests for a piece above itself 
				//if equals 0, pieces moves up 3.5, updates array, and calls updateArrayUp again
				pieces.array[row,column]=0;
				transform.position= transform.position + new Vector3(0,3.5f, 0);
				Debug.Log("Up Once");
				pieces.array[row-1,column]=1;
				updateArrayUp(pieces);
			}
			if (pieces.array [row-1, column] == pieces.array [row, column]) {
				combinePiecesUp (pieces, column, row);		
			}
			//if (pieces.array [row, column - 1] != pieces.array [row, column]) {
						
			//}
		}
	}
	void combinePiecesUp(gamePieceArray pieces, int column, int row){
		pieces.array [row-1, column] *= 2;
		//Instantiate (spawnObject, new Vector3(-5.25f,1.25f,5f), Quaternion.identity);
		Destroy (GameObject.Find("testGamePiece(clone)"));
		Debug.Log ("Destroyed");
	}

}





















