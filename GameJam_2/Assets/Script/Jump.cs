using UnityEngine;
using System.Collections;

public class Jump : MonoBehaviour {

	public float speed;
	public int cout;
    public GameObject shot;
    public Transform shotSpawn;
    public float fireRate;

    private Rigidbody rd;
    private float nextFire;

    bool canjump;


	void Start () {
		rd = GetComponent<Rigidbody> ();
		cout = 0;
	}
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
    void Update ()
    {
        if (Input.GetButton("Fire1") && Time.time > nextFire)
        {
            nextFire = Time.time + fireRate;
            Instantiate(shot, shotSpawn.position, shotSpawn.rotation);
        }
    }

}
