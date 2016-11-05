using UnityEngine;
using System.Collections;

public class CameraMove : MonoBehaviour {
    Vector3 cameraMove;
    float diffPos;
    bool moveLeft;
    bool moveRight;
	// Use this for initialization
	void Start ()
    {
        cameraMove = new Vector3(.11f, 0, 0);
	}
	
	// Update is called once per frame
	void Update ()
    {
        diffPos = CameraPosition.posX - PlayerPosition.posX;
        /*if (Move.dir == 1 && !moveLeft)
        {
            moveRight = true;
        }
        if (Move.dir == 0 && !moveRight)
        {
            moveLeft = true;
        }
        if (moveRight && diffPos < 6f && Input.GetKey("right"))
        {
            transform.position = transform.position + cameraMove;
            Debug.Log(CameraPosition.posX);
        }
        if (moveLeft && diffPos > -6f && Input.GetKey("left"))
        {
            transform.position = transform.position - cameraMove;
            Debug.Log(CameraPosition.posX);
        }
        if(diffPos > 6 || Input.GetKeyUp("right"))
        {
            moveRight = false;
        }
        if(diffPos < -6 || Input.GetKeyUp("left"))
        {
            moveLeft = false;
        }*/
        if (Move.dir == 1 && diffPos < 6f && Input.GetKey("right"))
        {
            transform.position = transform.position + cameraMove;
            Debug.Log(CameraPosition.posX);
        }
        if (Move.dir == 0 && diffPos > -6f && Input.GetKey("left"))
        {
            transform.position = transform.position - cameraMove;
            Debug.Log(CameraPosition.posX);
        }
    }
}
