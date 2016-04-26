using UnityEngine;
using System.Collections;

public class shoot : MonoBehaviour 
{

		public float speed;
		private Rigidbody rb;
		void Start ()
		{   
			rb = GetComponent<Rigidbody>();
			rb.velocity = transform.right * speed;
		}
    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "RedCude" || other.gameObject.tag == "Cubepre" || other.gameObject.tag == "coin" || other.gameObject.tag == "Cubeleft" || other.gameObject.tag == "Cubebase")
        {
            Destroy(this.gameObject);
        }
    }
}
