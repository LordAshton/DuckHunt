using UnityEngine;
using System.Collections;

public class UpdateScore : MonoBehaviour {
	public GUIText scoregui;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		scoregui.text = StaticVars.score.ToString ();

	}
}
