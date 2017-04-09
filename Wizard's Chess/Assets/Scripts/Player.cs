using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.VR;

public class Player : MonoBehaviour {
	//public Transform OculusEyeRight;
	public GameObject OculusEye;
	public float speed = 5.0f;
	//public Transform ;
	//public Transform 
	Vector3 newPos;
	// Use this for initialization
	void Start () {
		newPos = transform.position;
		
	}

	void OnTriggerEnter(Collider other){
		Debug.Log ("bishop");
	}
	
	// Update is called once per frame
	void Update () {
//		Debug.Log (transform.position);
//		//Ray ray = Camera.main.ScreenPointToRay (transform.position);
//		Ray ray = new Ray(transform.position,transform.TransformDirection (Vector3.forward));
//		RaycastHit hit=new RaycastHit();
//		Vector3 forward = transform.TransformDirection (Vector3.forward) * 50;
//		Debug.DrawRay (transform.position, forward, Color.green);
//		if (Physics.Raycast (ray, out hit, 100))
//			//Debug.DrawLine (ray.origin, hit.point);
//			print(hit.collider.gameObject.name);


		//OVRInput.Update();
//		if (OVRInput.Get (OVRInput.Button.One, OVRInput.Controller.Remote)) {
//			Debug.Log ("round button pressed");
//			transform.position += OculusEye.transform.right * 0.2f;
//		}
//			

			if (OVRInput.Get(OVRInput.Button.DpadRight, OVRInput.Controller.Remote))
			{
				transform.Translate(Vector3.right * speed * Time.deltaTime);
				//Debug.Log("Oculus Remote move right");
			}
			if (OVRInput.Get(OVRInput.Button.DpadLeft, OVRInput.Controller.Remote))
			{
				transform.Translate(Vector3.left * speed * Time.deltaTime);
				//Debug.Log("Oculus Remote move left");
			}
		  	if (OVRInput.Get(OVRInput.Button.DpadUp, OVRInput.Controller.Remote))
			{
			transform.Translate(Vector3.forward * speed * Time.deltaTime);
				//Debug.Log("Oculus Remote move up");
			}
			if (OVRInput.Get(OVRInput.Button.DpadDown, OVRInput.Controller.Remote))
			{
			transform.Translate(Vector3.back * speed * Time.deltaTime);
				//Debug.Log("Oculus Remote move down");
			}

			if (OVRInput.Get(OVRInput.Button.One, OVRInput.Controller.Remote))
			{
				transform.Translate(Vector3.up * speed * Time.deltaTime);
				Debug.Log("Oculus Remote move forward");
			}
			if (OVRInput.Get(OVRInput.Button.Two, OVRInput.Controller.Remote))
			{
			transform.Translate(Vector3.down * speed * Time.deltaTime);
				Debug.Log("Oculus Remote move back");
			}
			
//			RaycastHit h;
//			Ray r= Camera.main.ScreenPointToRay(Input.mousePosition);
//			if (Physics.Raycast (r, out h)) {
//				newPos = h.point;
//				transform.position = newPos;



			
	}
}

