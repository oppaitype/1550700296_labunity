﻿using UnityEngine;
using System.Collections;

public class DestroyByContact : MonoBehaviour 
{
	public GameObject explosion;
	public GameObject playerExplosion;
	public int scoreValue;
	private GameController gameController;

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

	void OnTriggerEnter(Collider other)
	{
        if (other.CompareTag("Boundary") || other.CompareTag("Enemy"))
        {
			return;
		}
        if (explosion != null)
        {
            Instantiate(explosion, transform.position, transform.rotation);
        }
       // Instantiate(explosion, transform.position, transform.rotation);
		if (other.tag == "Player") 
		{
			//Debug.Log("player tag");
			Instantiate (playerExplosion, other.transform.position, other.transform.rotation);
			gameController.GameOver ();
		}
//		Debug.Log("555");
		gameController.AddScore (scoreValue);
		Destroy (other.gameObject);
		Destroy (gameObject);
	}
}
