﻿using UnityEngine;
using System.Collections;

public class move : MonoBehaviour {
	private Rigidbody rb;
	public float speed;

	void Start ()
	{
		rb = GetComponent<Rigidbody>();
	}
	

	void FixedUpdate ()
	{
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");
		
		Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);
		rb.velocity = movement * speed;
	}
	void OnCollisionEnter(Collision other)
	{
		if (other.gameObject.tag== "enemie") 
		{
			Destroy(this.gameObject);
		}
	}
}
