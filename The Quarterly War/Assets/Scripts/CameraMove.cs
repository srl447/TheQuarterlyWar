using UnityEngine;
using System.Collections;

public class CameraMove : MonoBehaviour {
    Vector3 cameraMove;
    float diffPos;
	// Use this for initialization
	void Start ()
    {
        cameraMove = new Vector3(.1f, 0, 0);
	}
	
	// Update is called once per frame
	void Update ()
    {
        diffPos = CameraPosition.posX - PlayerPosition.posX;
        if (Move.dir == 1&& diffPos < 1.7f)
        {
            transform.position = transform.position + cameraMove;
            Debug.Log(CameraPosition.posX);
        }
        if (Move.dir == 0 && diffPos > -1.7f)
        {
            transform.position = transform.position - cameraMove;
            Debug.Log(CameraPosition.posX);
        }

    }
}
