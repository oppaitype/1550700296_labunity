using UnityEngine;
using System.Collections;

public class Enemie : MonoBehaviour {
	Rigidbody rb; 

	void Start()
	{
		rb = GetComponent<Rigidbody> ();
		rb.velocity = new Vector3 (5, 0, 0);
	}
	void OnCollisionEnter(Collision other)
	{
		if (other.gameObject.tag == "cube") 
		{
			rb.velocity = new Vector3 (-5, 0, 0);
			
		}
	}
}
