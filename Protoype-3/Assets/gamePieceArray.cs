using UnityEngine;
using System.Collections;

public class gamePieceArray : MonoBehaviour {
	public int[] piecesArray;// 0-3 top row, etc
	//0 is empty, 1 is pawn, 3 is bishop, 6 is knight, 9 is rook, 12 is queen, 15 is king 

	// Use this for initialization
	void Start () {
		for(int i=0;i<4;i++){
			piecesArray[i]=0;
		}
		Debug.Log(piecesArray);
	}
	
	// Update is called once per frame
	void Update () {

	}
}
