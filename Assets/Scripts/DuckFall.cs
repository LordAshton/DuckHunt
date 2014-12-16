using UnityEngine;
using System.Collections;

public class DuckFall : MonoBehaviour {

			public float fallSpeed = .1f;
		
		void Update () {
				transform.position += new Vector3 (0, -fallSpeed);	
			}

		void OnTriggerEnter2D () {
				Object.Destroy (this.gameObject);
			}
	}