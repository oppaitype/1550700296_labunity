using UnityEngine;
using System.Collections;

public class Effect : MonoBehaviour
{
	public GameObject playerExplosion;

	void OnCollisionEnter(Collision other) {
		if (other.gameObject.tag == "Cube2") 
		{
			Instantiate (playerExplosion, transform.position, transform.rotation);
			Destroy (this.gameObject);
		}

	}

}