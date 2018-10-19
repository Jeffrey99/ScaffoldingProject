using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VRTK;

public class screwdriver : MonoBehaviour {
    public GameObject rotator;
    public float Fall;
    private GameObject gamemanager;

    // Use this for initialization
    void Start () {
        gamemanager = GameObject.Find("DestinationPOINTER");

    }

    // Update is called once per frame
    void Update () {
        if (this.gameObject.GetComponent<VRTK_InteractableObject>().IsUsing())
        {
            Debug.Log("Aye");
            rotator.transform.Rotate(0,0,500 * Time.deltaTime);
            Fall += Time.deltaTime;
            if (Fall > 3)
            {
                gamemanager.GetComponent<DestinationMark>().tasksCompleted = 3;
                this.GetComponent<VRTK_InteractableObject>().isGrabbable = false;
                this.GetComponent<VRTK_InteractableObject>().enabled = false;
                this.GetComponent<VRTK_InteractObjectHighlighter>().enabled = false;
                Fall = 0;

            }
        }

    }
}
