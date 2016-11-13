using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class SecondWin : MonoBehaviour {
    int timer;
    public ParticleSystem winShine;
	// Use this for initialization
	void Start ()
    {
       timer = 0;
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
        }
        if (timer == 70)
        {
            SceneManager.LoadScene(5);
            CustomerCollect.totalDelivered = 0;
            Timer.timer = 0;
            DrawTimer.cusNeed = 7;
        }

    }
}
