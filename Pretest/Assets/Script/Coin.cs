using UnityEngine;
using System.Collections;

public class Coin : MonoBehaviour {

	void OnCollisionEnter(Collision other)
	{
		if (other.gameObject.tag == "player") {
			Destroy (this.gameObject);
		}
	}
}
