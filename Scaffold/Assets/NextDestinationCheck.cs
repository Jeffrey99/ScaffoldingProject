using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextDestinationCheck : MonoBehaviour {
    private GameObject gamemanager;
    public int wichTask;
	// Use this for initialization
	void Start () {
        gamemanager = GameObject.Find("DestinationPOINTER");

    }
	
	// Update is called once per frame
	void Update () {
		
	}
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Playerhead")
        {
            gamemanager.GetComponent<DestinationMark>().tasksCompleted = wichTask;
            Destroy(other.gameObject);
        }
    }
}
