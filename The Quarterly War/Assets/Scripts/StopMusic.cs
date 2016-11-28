using UnityEngine;
using System.Collections;

public class StopMusic : MonoBehaviour {
    AudioSource bgmPlayer;
    public static bool transition = false;
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
            IntroWin.stopMusic = false;
            SecondWin.stopMusic = false;
            Win.stopMusic = false;
            //timer = 0;
        }
        if (transition)
        {
            bgmPlayer.Play();
            transition = false;
        }
	}
}
