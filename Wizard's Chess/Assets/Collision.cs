﻿using UnityEngine;
using System.Collections;

public class Collision : MonoBehaviour{

	void OnTriggerEnter(Collider other){
		Debug.Log ("bishop");
	}
}