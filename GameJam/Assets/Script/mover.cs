﻿using UnityEngine;
using System.Collections;

public class mover : MonoBehaviour 
{
	public float speed;
	private Rigidbody rb;

	void Start ()
	{
		rb = GetComponent<Rigidbody> ();
	}

	public void Jump ()
	{
		rb.velocity = (Vector3.up * speed);
	}
}
