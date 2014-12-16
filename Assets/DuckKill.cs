using UnityEngine;
using System.Collections;

public class DuckKill : MonoBehaviour {

			public GameObject Duck;
		
		void OnTriggerEnter2D () {
				Object.Destroy (Duck);
			
			}

}