using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;

public class PlayerHead : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Hit");
        if(collision.gameObject.tag == "Candybar")
        {
            Destroy(collision.gameObject);
        }

    }
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Nailsbox")
        {
            other.gameObject.GetComponent<Rigidbody>().AddForce(transform.up * 20);
        }
        if (other.gameObject.tag == "Tip")
        {
            Destroy(other.gameObject);
        }
    }
}
