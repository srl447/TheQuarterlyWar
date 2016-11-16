using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class DrawTimer : MonoBehaviour
{
    int  timeToDisplay;
    //int  cusLeft;
    float oldCust;
    bool blueTime;
    int blueCount;
    public static int cusNeed = 2;
    public GameObject clock;
    public GameObject custFace;
    public GameObject cameraT;
    GUIStyle guiTime = new GUIStyle();
    GUIStyle guiCust = new GUIStyle();
    GUIStyle guiColon = new GUIStyle();
    // Use this for initialization
    void Start ()
    {
        guiTime.fontSize = 30;
        guiCust.fontSize = 30;
        guiColon.fontSize = 30;
        guiTime.normal.textColor = Color.white;
        guiCust.normal.textColor = Color.white;
        guiColon.normal.textColor = Color.white;
        GameObject clockUI = Instantiate(clock) as GameObject;
        GameObject custUI = Instantiate(custFace) as GameObject;
        clockUI.transform.SetParent(cameraT.transform);
        custUI.transform.SetParent(cameraT.transform);
        clockUI.transform.position = Camera.main.ViewportToWorldPoint(new Vector3 (.035f, .915f, 10));
        custUI.transform.position = Camera.main.ViewportToWorldPoint(new Vector3(.035f, .8f, 10));
    }
	
	// Update is called once per frame
	void Update ()
    {
        timeToDisplay = Mathf.RoundToInt((Timer.maxTime - Timer.timer)/60);
        //cusLeft = Mathf.RoundToInt(cusNeed - CustomerCollect.totalDelivered);
        if (timeToDisplay < 22 && timeToDisplay %2 == 0)
        {
            //guiTime.normal.textColor = Color.red;
            //guiTime.fontSize = 31;
        }
        if (timeToDisplay < 22 && timeToDisplay % 2 == 1)
        {
            //guiTime.normal.textColor = Color.white;
            //guiTime.fontSize = 30;
        }
        if (CustomerCollect.totalDelivered > oldCust)
        {
            blueTime = true;
            blueCount = 0;
        }
        if (blueCount < 20 && blueTime)
        {
            //guiCust.normal.textColor = Color.blue;
            blueCount++;
        }
        if (blueCount >= 20)
        {
            //guiCust.normal.textColor = Color.white;
            blueTime = false;
            blueCount = 0;
        }
        oldCust = CustomerCollect.totalDelivered;


    }
    void OnGUI()
    {
        GUI.Label(new Rect(50, 10, 100, 20), ":", guiColon);
        GUI.Label(new Rect(58, 12, 100, 20), timeToDisplay.ToString(), guiTime);
        GUI.Label(new Rect(50, 50, 100, 20), ":", guiColon);
        GUI.Label(new Rect(58, 52, 100, 20), CustomerCollect.totalDelivered.ToString() + "/" + cusNeed.ToString(), guiCust);

    }
}
