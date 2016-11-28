using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class IntroWin : MonoBehaviour {
    int timer;
    public ParticleSystem winShine;
    public AudioClip winSound;
    AudioSource winPlay;
    public static bool stopMusic;
    bool played = false;
    // Use this for initialization
    void Start ()
    {
        timer = 0;
        winPlay = GetComponent<AudioSource>();


    }
    void Update()
    {
        if (CustomerCollect.totalDelivered == 2)
        {
            timer++;
            stopMusic = true;
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
            SceneManager.LoadScene(4);
            CustomerCollect.totalDelivered = 0;
            Timer.timer = 0;
        }

    }
}
