using UnityEngine;
using System.Collections;

public class Moveenemie : MonoBehaviour {


    void Start()
    {
        Rigidbody rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(5, 0, 0);
    }
    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Cubeleft" || other.gameObject.tag == "shot")
        {
            Destroy(this.gameObject);
        }
    }
}
