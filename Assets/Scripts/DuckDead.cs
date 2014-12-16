using UnityEngine;
using System.Collections;

public class DuckDead : MonoBehaviour
{
	public GameObject ShotDuck;
	public GameObject DeadDuck;
	public int scoreValue;
	public GameController gameController;

	public GUIText scoreText;
	private int score;
	
	void Start ()
	{
		GameObject gameControllerObject = GameObject.FindWithTag ("GameController");
		if (gameControllerObject != null)
		{
			gameController = gameControllerObject.GetComponent <GameController>();
		}
		if (gameController == null)
		{
			Debug.Log ("Cannot find 'GameController' script");
		}
	}
	
	void OnTriggerEnter2D(Collider2D other) 
	{
		if (other.tag == "Boundary")
		{
			return;
		}
		if (ShotDuck != null)
		Instantiate(ShotDuck, transform.position, transform.rotation);


		if (other.tag == "Player")
		{
			if (DeadDuck != null)
			Instantiate(DeadDuck, other.transform.position, other.transform.rotation);
		}


		StaticVars.score++;
		if (gameController != null)
		gameController.AddScore (scoreValue);
		Object.Destroy(gameObject);
		
	}
	void UpdateScore ()
	{
		scoreText.text = "Score: " + score;
	}
}