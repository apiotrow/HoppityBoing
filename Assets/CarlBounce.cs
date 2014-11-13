using UnityEngine;
using System.Collections;

public class CarlBounce : MonoBehaviour {

	public GameObject trampMesh;


	void Start () {
	
	}
	

	void Update () {
	
	}
	

	void OnTriggerEnter (Collider other)
	{
		//if (other.gameObject.name == "TrampolineMesh") {
		if (other.gameObject == trampMesh) {
			Debug.Log("hi");
			rigidbody.velocity = Vector3.zero;
			rigidbody.AddForce(new Vector3(0f, 100000f, 0f));
			
		}
	}

//	void OnCollisionEnter (Collision other)
//	{
//		//if (other.gameObject.name == "TrampolineMesh") {
//		if (other.gameObject == trampMesh) {
//			Debug.Log("hi");
//			rigidbody.velocity = Vector3.zero;
//			rigidbody.AddForce(new Vector3(0f, 10000f, 0f));
//			
//		}
//	}
}
