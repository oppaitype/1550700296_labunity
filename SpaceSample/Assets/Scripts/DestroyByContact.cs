using UnityEngine;
using System.Collections;

public class DestroyByContact : MonoBehaviour 
{
	public GameObject explosion;
	public GameObject playerExplosion;

	void OnTriggerEnter(Collider other)
	{
		if (other.tag == "Boundary") 
		{
			return;
		}

		Instantiate(explosion, transform.position, transform.rotation);
		if (other.tag == "Player") 
		{
			//Debug.Log("player tag");
			Instantiate (playerExplosion, other.transform.position, other.transform.rotation);
		}
//		Debug.Log("555");
		Destroy (other.gameObject);
		Destroy (gameObject);
	}
}
