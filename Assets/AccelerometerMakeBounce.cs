using UnityEngine;
using System.Collections;

public class AccelerometerMakeBounce : MonoBehaviour
{

	float xAccel;
	float yAccel;
	float zAccel;
	public float speed = 6.0F;
	public float jumpSpeed = 8.0F;
	public float gravity = 20.0F;
	private Vector3 moveDirection = Vector3.zero;

	void OnGUI ()
	{
		float acc;
		string text;
		
		acc = Input.acceleration.x;
		text = "x accel: " + acc.ToString ();
		GUI.Box (new Rect (Screen.width - 200, 0, 200, 30), text);
		
		acc = Input.acceleration.y;
		text = "y accel: " + acc.ToString ();
		GUI.Box (new Rect (Screen.width - 400, 0, 200, 30), text);
		
		acc = Input.acceleration.z;
		text = "z accel: " + acc.ToString ();
		GUI.Box (new Rect (Screen.width - 600, 0, 200, 30), text);
		
	}

	// Use this for initialization
	void Start ()
	{
		
	}
	
	// Update is called once per frame
	void Update ()
	{

		xAccel = Input.acceleration.x;
		yAccel = Input.acceleration.y;
		zAccel = Input.acceleration.z;
		
		float xAccelabs = Mathf.Abs (xAccel);
		float yAccelabs = Mathf.Abs (yAccel);
		float zAccelabs = Mathf.Abs (zAccel);

		Vector3 jumpVector = new Vector3 (0, yAccel * 100f, 0);

		if (yAccelabs > 2 && transform.position.y < 1.5f) {
			rigidbody.AddForce (jumpVector);
		}
			

//		if (Input.GetKeyDown (KeyCode.Q) && transform.position.y < 1.5f){
//			Vector3 test = new Vector3 (0, 400f, 0); 
//			rigidbody.AddForce(test);
//				}



	}
}



