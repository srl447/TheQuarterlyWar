using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class IntroWin : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
    void Update()
    {
        if (CustomerCollect.totalDelivered == 2)
        {
            SceneManager.LoadScene(4);
            CustomerCollect.totalDelivered = 0;
            Timer.timer = 0;
        }

    }
}
