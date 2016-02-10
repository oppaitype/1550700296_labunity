using UnityEngine;
using System.Collections;

public class mover : MonoBehaviour 
{
	public float speed;
	private Rigidbody rb;

	void Start ()
	{
		rb = GetComponent<Rigidbody> ();
	}
	void FixedUpdate ()
	{
		if (Input.GetKey (KeyCode.W)) 
		{
			rb.AddForce (Vector3.up * speed);
		}
		if (Input.GetKey (KeyCode.A)) 
		{
			rb.AddForce (Vector3.left * speed);
		}
	}
}
