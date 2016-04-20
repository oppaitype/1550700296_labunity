using UnityEngine;
using System.Collections;

public class movecoin : MonoBehaviour{
	
	void Start()
	{
		Rigidbody rb = GetComponent<Rigidbody> ();
		rb.velocity = new Vector3 (5, 0, 0);
	}
	void OnCollisionEnter(Collision other)
	{
		if (other.gameObject.tag == "player") 
		{
			Destroy (this.gameObject);
		}
		else if (other.gameObject.tag== "Cubeleft") 
		{
			Destroy(this.gameObject);
		}

		
	}

		
}