﻿using UnityEngine;
using System.Collections;

public class AccelerometerMakeBounce : MonoBehaviour {

	void OnGUI(){
		float acc;
		string text;
		
		acc = Input.acceleration.x;
		text = "x accel: " + acc.ToString();
		GUI.Box (new Rect (Screen.width - 200, 0, 200, 30), text);
		
		acc = Input.acceleration.y;
		text = "y accel: " + acc.ToString();
		GUI.Box (new Rect (Screen.width - 400, 0, 200, 30), text);
		
		acc = Input.acceleration.z;
		text = "z accel: " + acc.ToString();
		GUI.Box (new Rect (Screen.width - 600, 0, 200, 30), text);
		
	}
	
	float xAccel;
	float yAccel;
	float zAccel;
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		xAccel = Input.acceleration.x;
		yAccel = Input.acceleration.y;
		zAccel = Input.acceleration.z;
		
		float xAccelabs = Mathf.Abs(xAccel);
		float yAccelabs = Mathf.Abs(yAccel);
		float zAccelabs = Mathf.Abs(zAccel);

		Vector3 jumpVector = new Vector3 (0, yAccel, 0);
		
		if (yAccel > 2) {
			rigidbody.AddForce(jumpVector);
		}

	}
}



