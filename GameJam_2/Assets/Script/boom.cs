using UnityEngine;
using System.Collections;

public class boom : MonoBehaviour {
	Rigidbody rd;

	public GameObject playerExplosion;
	void Start ()
	{
		 rd = GetComponent<Rigidbody> ();

	}
	void OnCollisionEnter (Collision other) {
		if (other.gameObject.tag == "boomm" || other.gameObject.tag=="CubeM") 
		{
			Instantiate (playerExplosion, transform.position, transform.rotation);
			Destroy (this.gameObject);
		}
		else if (other.gameObject.tag == "CubeF")
		{

			rd.velocity = new Vector3 (0, -lastVelocity, 0);
		}

	}
	float lastVelocity;
	void Update ()
	{


		if (rd != null && rd.velocity.y < 0 ) {
			lastVelocity = rd.velocity.y;
			Debug.LogFormat("Update >> lastVelocity = {0}",lastVelocity);
		}
	}
	void OnCollisionExit(Collision other)
	{
		if (other.gameObject.tag== "Cylinder")
		{

			rd.velocity = new Vector3 (0, rd.velocity.y, 0);
		}
	}

}
