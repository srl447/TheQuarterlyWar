using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TextCust : MonoBehaviour {
    Text cust;
    public static int cusNeed = 2;
    float oldCust;
    bool blueTime;
    int blueCount;
    float total = CustomerCollect.totalDelivered;
    // Use this for initialization
    void Start ()
    {
       cust  = gameObject.GetComponent<Text>();
       cust.text = ":" + total + "/" + cusNeed;

    }
	
	// Update is called once per frame
	void Update ()
    {
        total = CustomerCollect.totalDelivered;
        cust.text = ":" + total + "/" + cusNeed;
        if (CustomerCollect.totalDelivered > oldCust)
        {
            blueTime = true;
            blueCount = 0;
        }
        if (blueCount < 20 && blueTime)
        {
            cust.color = Color.blue;
            blueCount++;
        }
        if (blueCount >= 20)
        {
            cust.color = Color.white;
            blueTime = false;
            blueCount = 0;
        }
        oldCust = CustomerCollect.totalDelivered;
    }
}
