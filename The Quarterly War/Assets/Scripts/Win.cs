using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Win : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (CustomerCollect.totalDelivered == 7)
        {
            SceneManager.LoadScene(2);
        }
	
	}
}
