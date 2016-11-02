using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    public static float timer;
    public static float maxTime;
    public GameObject deathScreen;
    public Vector3 offset;
	// Use this for initialization
	void Start ()
    {
        maxTime = 3600;
	
	}
	
	// Update is called once per frame
	void Update ()
    {
        timer++;
        if (timer == maxTime)
        {
            //GameObject lossScreen = Instantiate(deathScreen) as GameObject;
            //lossScreen.transform.parent = gameObject.transform;
            SceneManager.LoadScene(1);


        }
	
	}
}
