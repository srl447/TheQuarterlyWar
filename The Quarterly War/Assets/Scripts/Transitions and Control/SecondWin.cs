using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class SecondWin : MonoBehaviour {
    int timer;
    public ParticleSystem winShine;
    public AudioClip winSound;
    AudioSource winPlay;
    bool played = false;
    // Use this for initialization
    void Start ()
    {
       timer = 0;
       winPlay = GetComponent<AudioSource>();
    }
	
	// Update is called once per frame
	void Update ()
    {
        if (CustomerCollect.totalDelivered == 2)
        {
            timer++;
            if (!winShine.isPlaying)
            {
                winShine.Play();
            }
            if (!played)
            {
                winPlay.PlayOneShot(winSound, 1.1f);
                played = true;
            }
        }
        if (timer == 170)
        {
            SceneManager.LoadScene(5);
            CustomerCollect.totalDelivered = 0;
            Timer.timer = 0;
            TextCust.cusNeed = 7;
        }

    }
}
