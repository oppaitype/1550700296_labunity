﻿using UnityEngine;
using System.Collections;

public class cylinderMove : MonoBehaviour 
{
	public float speed;
	
	private Rigidbody rb;
	
	void Start()
	{
		rb = GetComponent<Rigidbody> ();
		rb.velocity = transform.right* speed;
	}
}