using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class IntroWin : MonoBehaviour {
    int timer;
    public ParticleSystem winShine;
	// Use this for initialization
	void Start ()
    {
        timer = 0;
	
	}
    void Update()
    {
        if (CustomerCollect.totalDelivered == 2)
        {
            timer++;
            if (!winShine.isPlaying)
            {
                winShine.Play();
            }
        }
        if (timer == 70)
        {
            SceneManager.LoadScene(4);
            CustomerCollect.totalDelivered = 0;
            Timer.timer = 0;
        }

    }
}
