using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Quitting : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey("escape"))
        {
            Application.Quit();
        }
        if (Input.GetKey("1"))
        {
            CustomerCollect.totalDelivered = 0;
            Timer.timer = 0;
            TextCust.cusNeed = 2;
            SceneManager.LoadScene(0);
        }
    }
}
