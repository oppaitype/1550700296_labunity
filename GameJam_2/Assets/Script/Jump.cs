using UnityEngine;
using System.Collections;

public class Jump : MonoBehaviour {

	public float speed;
	private Rigidbody rd;
	bool canjump;
	// Use this for initialization
	void Start () {
		rd = GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	public void Jume() {

		if (canjump) {
			rd.velocity = (Vector3.up * speed);
		}
	}
	void OnCollisionEnter(Collision other)
	{
		if (other.gameObject.tag == "Cubepre") {
			canjump = true;
		}
	}
	void OnCollisionExit(Collision other)
	{
		if (other.gameObject.tag == "Cubepre") {
			canjump = false;
		}
	}
}
