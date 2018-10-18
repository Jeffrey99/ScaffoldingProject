using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DestinationMark : MonoBehaviour {
    public GameObject destination;
    public Text dist;
    public GameObject[] destinations;
    public int tasksCompleted;

    void Start()
    {

    }

    void Update()
    {
        this.transform.position = destinations[tasksCompleted].transform.position;
        transform.LookAt(destination.transform);
        float distance = Vector3.Distance(destination.transform.position, this.transform.position); ;
        dist.text =distance.ToString("0") + " METERS";
    }
}
