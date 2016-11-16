using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TextTimer : MonoBehaviour {
    Text time;
    int timeToDisplay;
    // Use this for initialization
    void Start ()
    {
        time = gameObject.GetComponent<Text>();
        time.text = ":" + timeToDisplay;
    }
	
	// Update is called once per frame
	void Update ()
    {
        timeToDisplay = Mathf.RoundToInt((Timer.maxTime - Timer.timer) / 60);
        time.text = ":" + timeToDisplay;
        if (timeToDisplay < 22 && timeToDisplay % 2 == 0)
        {
            time.color = Color.red;
        }
        if (timeToDisplay < 22 && timeToDisplay % 2 == 1)
        {
            time.color = Color.white;
        }
    }
}
