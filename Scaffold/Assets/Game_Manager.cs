using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;
public class Game_Manager : MonoBehaviour {
    public GameObject FadeIn;
    public GameObject FadeOut;
    // Use this for initialization
    void Start () {
        fadeIn();
        AkSoundEngine.PostEvent("Dialog1", gameObject);
        AkSoundEngine.PostEvent("Ambient", gameObject);


    }

    // Update is called once per frame
    void Update () {
		
	}

    public void fadeIn()
    {
        FadeIn.GetComponent<Animator>().Play("FadeIn");
    }

    public void fadeOut()
    {
        FadeOut.GetComponent<Animator>().Play("FadeOut");

    }
}
