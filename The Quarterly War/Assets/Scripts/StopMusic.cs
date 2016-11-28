using UnityEngine;
using System.Collections;

public class StopMusic : MonoBehaviour {
    AudioSource bgmPlayer;
	// Use this for initialization
	void Start ()
    {
        bgmPlayer = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update ()
    {
	if (IntroWin.stopMusic || SecondWin.stopMusic || Win.stopMusic)
        {
            bgmPlayer.Stop();
        }
	}
}
