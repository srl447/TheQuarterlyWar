using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class DrawTimer : MonoBehaviour
{
    int  timeToDisplay;
    int cusLeft;
    public static int cusNeed = 2;
    public GameObject clock;
    GUIStyle guiTime = new GUIStyle();
    GUIStyle guiCust = new GUIStyle();
    // Use this for initialization
    void Start ()
    {
        guiTime.fontSize = 30;
        guiCust.fontSize = 30;
        guiTime.normal.textColor = Color.white;
        guiCust.normal.textColor = Color.white;
    }
	
	// Update is called once per frame
	void Update ()
    {
        timeToDisplay = Mathf.RoundToInt((Timer.maxTime - Timer.timer)/60);
        cusLeft = Mathf.RoundToInt(cusNeed - CustomerCollect.totalDelivered);
        if (timeToDisplay < 20)
        {
            guiTime.normal.textColor = Color.red;
        }

    }
    void OnGUI()
    {
        GUI.Label(new Rect(50, 10, 100, 20),":" + timeToDisplay.ToString(), guiTime);
        GUI.Label(new Rect(50, 50, 100, 20), ":" + CustomerCollect.totalDelivered.ToString() + "/" + cusNeed.ToString(), guiCust);

    }
}
