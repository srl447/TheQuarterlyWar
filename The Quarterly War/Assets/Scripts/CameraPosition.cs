using UnityEngine;
using System.Collections;

public class CameraPosition : MonoBehaviour {
    public static float posX;
    public static float posY;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        posX = transform.position.x;
        posY = transform.position.y;
	
	}
}
