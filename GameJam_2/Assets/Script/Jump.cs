using UnityEngine;
using System.Collections;

public class Jump : MonoBehaviour {

	public float speed;
	private Rigidbody rd;
	public int cout;
	bool canjump;
	// Use this for initialization
	void Start () {
		rd = GetComponent<Rigidbody> ();
		cout = 0;
	}
	
	// Update is called once per frame
	public void Jume() {

		if (canjump || cout < 2) {
			rd.velocity = (Vector3.up * speed);
			cout++;
		}
	}
	void OnCollisionEnter(Collision other)
	{
		if (other.gameObject.tag == "Cubepre") {
			canjump = true;
			cout = 0;
		}
		if (other.gameObject.tag== "coin") 
		{
			Destroy(this.gameObject);
		}
	}
	void OnCollisionExit(Collision other)
	{
		if (other.gameObject.tag == "Cubepre") {
			canjump = false;
		}
	}

}
