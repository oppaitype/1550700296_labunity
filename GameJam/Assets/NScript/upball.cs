using UnityEngine;
using System.Collections;

public class upball : MonoBehaviour {

	public float speed;
	private Rigidbody rd;
	// Use this for initialization
	void Start () {
		rd = GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	public void Jume() {


			rd.AddForce (Vector3.up * speed);

	
	}
}
