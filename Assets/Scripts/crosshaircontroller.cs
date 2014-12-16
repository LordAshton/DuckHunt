using UnityEngine;
using System.Collections;

public class crosshaircontroller : MonoBehaviour {
	
	public Camera cam;
	
	void Start () {
		if (cam == null) {
			cam = Camera.main;
		}
	}
	
	void FixedUpdate () {
		Vector3 rawPosition = cam.ScreenToWorldPoint (Input.mousePosition);
		rigidbody2D.MovePosition (rawPosition);

		
	}
}
