using UnityEngine;
using System.Collections;


public class ChessPlay : MonoBehaviour {


	public GameObject[] gameObjects = new GameObject[2];



	private static int _boardSize   =  8;
	//private int[,] _boardPieces = new int[_boardSize,_boardSize];

	private GameObject[,] _chessPieces = new GameObject[_boardSize,_boardSize];



	// Initialize the board area
	void Start()
	{
		CreateBoard();

	}

	// Create the board by placing cubes
	void CreateBoard()
	{


		//for(int i = 0; i < _boardSize; i++)
		//{
		//	for(int j = 0; j < _boardSize; j++)
		//	{
		//		if((i+j)%2 == 0)
		//		{
		//			Object.Instantiate(CubeDark,new Vector3(i,_boardHeight,j), Quaternion.identity);	
		//		}
		//		else
		//		{
		//			Object.Instantiate(CubeLight,new Vector3(i,_boardHeight,j), Quaternion.identity);
		//		}
		//	}
		//}



		Transform[] ts = this.gameObject.transform.GetComponentsInChildren<Transform>();

		foreach (Transform t in ts) {

			if(t.gameObject.name.Contains("Rook"))
			{
					 
				if (_chessPieces [0,0] == null) {
					_chessPieces [0,0] = t.gameObject;
				} else if(_chessPieces [0,7] == null){
					_chessPieces [0,7] = t.gameObject;
				} else if (_chessPieces [7,0] == null) {
					_chessPieces [7,0] = t.gameObject;
				} else {
					_chessPieces [7,7] = t.gameObject;
				}
					
			}
					


			if(t.gameObject.name.Contains("Knight"))
			{

				if (_chessPieces [0,1] == null) {

					_chessPieces [0,1] = t.gameObject;
				} else if (_chessPieces [0,6] == null) {

					_chessPieces [0,6] = t.gameObject;
				} else if (_chessPieces [7,1] == null) {

					_chessPieces [7,1] = t.gameObject;
				} else {
					_chessPieces [7,6] = t.gameObject;

				}

			}
			if(t.gameObject.name.Contains("Bishop"))
			{

				if (_chessPieces [0,2] == null) {

					_chessPieces [0,2] = t.gameObject;
				} else if (_chessPieces [0,5] == null) {

					_chessPieces [0,5] = t.gameObject;
				} else if (_chessPieces [7,2] == null) {

					_chessPieces [7,2] = t.gameObject;
				} else {
					_chessPieces [7,5] = t.gameObject;

				}

			}
			if(t.gameObject.name.Contains("Queen"))
			{
				if (_chessPieces [0,3] == null) {
					_chessPieces [0,3] = t.gameObject;

				} else {
					_chessPieces [7,3] = t.gameObject;
				}
			}
			if(t.gameObject.name.Contains("King"))
			{
				if (_chessPieces [0,4] == null) {
					_chessPieces [0,4] = t.gameObject;
				} else {
					_chessPieces [7,4] = t.gameObject;
				}
			}

			if (t.gameObject.name.Contains ("Pawn")) {

				if (_chessPieces [1,0] == null) {

					_chessPieces [1,0] = t.gameObject;
				} else if (_chessPieces [1,1] == null) {

					_chessPieces [1,1] = t.gameObject;
				} else if (_chessPieces [1,2] == null) {

					_chessPieces [1,2] = t.gameObject;
				} else if(_chessPieces [1,3] == null){
					_chessPieces [1,3] = t.gameObject;

				}

				else if (_chessPieces [1,4] == null) {

					_chessPieces [1,4] = t.gameObject;
				} else if (_chessPieces [1,5] == null) {

					_chessPieces [1,5] = t.gameObject;
				} else if (_chessPieces [1,6] == null) {

					_chessPieces [1,6] = t.gameObject;
				} else if(_chessPieces [1,7] == null){
					_chessPieces [1,7] = t.gameObject;

				}

				else if (_chessPieces [6,0] == null) {

					_chessPieces [6,0] = t.gameObject;
				} else if (_chessPieces [6,1] == null) {

					_chessPieces [6,1] = t.gameObject;
				} else if (_chessPieces [6,2] == null) {

					_chessPieces [6,2] = t.gameObject;
				} else if(_chessPieces [6,3] == null){
					_chessPieces [6,3] = t.gameObject;

				}

				else if (_chessPieces [6,4] == null) {

					_chessPieces [6,4] = t.gameObject;
				} else if (_chessPieces [6,5] == null) {

					_chessPieces [6,5] = t.gameObject;
				} else if (_chessPieces [6,6] == null) {

					_chessPieces [6,6] = t.gameObject;
				} else if(_chessPieces [6,7] == null){
					_chessPieces [6,7] = t.gameObject;

				}



			}

		}
			


	}


	void Update()
	{
		//if (Input.GetMouseButtonDown (2)) {
		//	Debug.Log ("mouse pos" + transform.position);
		//	Ray ray = Camera.main.ScreenPointToRay (transform.position);
		//	RaycastHit hit;
		//	if (Physics.Raycast (ray, out hit, 100))
		//		Debug.DrawLine (ray.origin, hit.point);
		//}

		//Ray ray = Camera.main.ScreenPointToRay (transform.position);
//		Ray ray = new Ray(transform.position,transform.forward);
//		Debug.Log ("inside chess play update");
//		RaycastHit hit;
//		if (Physics.Raycast (ray, out hit, 100)&&hit.collider.gameObject.tag.Equals("Bishop1" )) {
//			Debug.Log ("hit"+hit.collider.gameObject.tag);
//
//				Debug.DrawRay (transform.position, transform.forward, Color.black, 1);
//		}

	}

	void onCollisionEnter(Collision c)
	{
		Debug.Log (c.gameObject.tag);
		c.gameObject.transform.Translate (Vector3.back * 1.0f);
		//transform.Translate(Vector3.back * speed* Time.deltaTime);
	}





}