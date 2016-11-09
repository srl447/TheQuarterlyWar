using UnityEngine;
using System.Collections;

public class MusicSpeed : MonoBehaviour {
    float musicPitch;
	// Use this for initialization
	void Start ()
    {
        musicPitch = 1f;
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (Mathf.RoundToInt((Timer.maxTime - Timer.timer) / 60) <= 24)
        {
            musicPitch += .00016f;
        }
        GetComponent<AudioSource>().pitch = musicPitch;
        /*if (Mathf.RoundToInt((Timer.maxTime - Timer.timer) / 60) == 20)
        {
            GetComponent<AudioSource>().pitch = 1.08f;
        }
        if (Mathf.RoundToInt((Timer.maxTime - Timer.timer) / 60) == 18)
        {
            GetComponent<AudioSource>().pitch = 1.1f;
        }
        if (Mathf.RoundToInt((Timer.maxTime - Timer.timer) / 60) == 16)
        {
            GetComponent<AudioSource>().pitch = 1.1f;
        }
        if (Mathf.RoundToInt((Timer.maxTime - Timer.timer) / 60) == 10)
        {
            GetComponent<AudioSource>().pitch = 1.19f;
        }
        if (Mathf.RoundToInt((Timer.maxTime - Timer.timer) / 60) == 5)
        {
            GetComponent<AudioSource>().pitch = 1.25f;
        }*/
    }
}
