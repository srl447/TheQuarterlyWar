using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class DrawTimer : MonoBehaviour
{
    int  timeToDisplay;
    int cusLeft;
    public static int cusNeed = 2;
    // Use this for initialization
    void Start ()
    {
	}
	
	// Update is called once per frame
	void Update ()
    {
        timeToDisplay = Mathf.RoundToInt((Timer.maxTime - Timer.timer)/60);
        cusLeft = Mathf.RoundToInt(cusNeed - CustomerCollect.totalDelivered);

    }
    void OnGUI()
    {
        GUIStyle guiStyle = new GUIStyle();
        guiStyle.fontSize = 30;
        guiStyle.normal.textColor = Color.white;
        GUI.Label(new Rect(10, 10, 100, 20), "Time Left: " + timeToDisplay.ToString(), guiStyle);
        GUI.Label(new Rect(10, 40, 100, 20), "Customers Left: " + cusLeft.ToString(), guiStyle);

    }
}
