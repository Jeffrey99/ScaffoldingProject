using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class carspawn : MonoBehaviour {
    public GameObject spawn1;
    public GameObject spawn2;
    public GameObject[]  cars;
    public GameObject[] cars2;

    public float timer1;
    public float timer2;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        timer1 += Time.deltaTime;
        timer2 += Time.deltaTime;

        if (timer1 > Random.RandomRange(20, 40))
        {
            Instantiate(cars[0], spawn1.transform.position, Quaternion.identity);
            timer1 = 0;

        }
        if (timer2 > Random.RandomRange(20, 40))
        {
            Instantiate(cars2[0], spawn2.transform.position, Quaternion.identity);
            timer2 = 0;

        }
    }
}
