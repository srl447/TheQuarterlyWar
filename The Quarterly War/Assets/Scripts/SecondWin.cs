using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class SecondWin : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (CustomerCollect.totalDelivered == 2)
        {
            SceneManager.LoadScene(5);
            CustomerCollect.totalDelivered = 0;
            Timer.timer = 0;
            DrawTimer.cusNeed = 7;
        }

    }
}
