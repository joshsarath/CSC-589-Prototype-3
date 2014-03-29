using UnityEngine;
using System.Collections;

public class gamePieceArray : MonoBehaviour {
	public int[,] array= new int[4,4];

	public  GameObject spawnObject;

	//public int[,] array;// 0-3 top row, etc
	//0 is empty, 1 is pawn, 3 is bishop, 6 is knight, 9 is rook, 12 is queen, 15 is king 

	// Use this for initialization
	void Start () {
		for(int i=0; i<4; i++){
			for(int j=0; j<4; j++){
				array[i,j]=0;
				}
			Debug.Log(i+":"+array[i,0]+","+array[i,1]+","+array[i,2]+","+array[i,3]);
			}
		GameObject gamePiece =(GameObject) Instantiate(spawnObject, new Vector3(-5.25f,1.25f,5f), Quaternion.identity); 
	}
			
	// Update is called once per frame
	void Update () {
		if (Input.GetKey("up")||Input.GetKey("down")||Input.GetKey("left")||Input.GetKey("right")){
			GameObject gamePiece =(GameObject) Instantiate(spawnObject, new Vector3(-5.25f,1.25f,5f), Quaternion.identity); 
		}
	}
}
