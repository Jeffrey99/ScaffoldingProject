using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DestinationMark : MonoBehaviour {
    public GameObject destination;
    public Text dist;

    void Start()
    {

    }

    void Update()
    {
        transform.LookAt(destination.transform);
        float distance = Vector3.Distance(destination.transform.position, this.transform.position); ;
        dist.text =distance.ToString("0") + " METERS";
    }
}
