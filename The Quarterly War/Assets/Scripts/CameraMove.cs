﻿using UnityEngine;
using System.Collections;

public class CameraMove : MonoBehaviour {
    Vector3 cameraMove;
    Vector3 cameraMoveDown;
    Vector3 cameraMoveUp;
    float diffPos;
    float diffPosY;
    bool moveLeft;
    bool moveRight;
    int wait;
    int wait2;
    int hold = 0;
    public static float floor1 = -1.01f;
    public static float floor2 = -1.1f;
	// Use this for initialization
	void Start ()
    {
        wait = 0;
        cameraMove = new Vector3(.08f, 0, 0);
        cameraMoveDown = new Vector3(0, .045f, 0);
        cameraMoveUp = new Vector3(0, .075f, 0);
	}
	
	// Update is called once per frame
	void FixedUpdate ()
    {
        diffPos = CameraPosition.posX - PlayerPosition.posX;
        diffPosY = CameraPosition.posY - PlayerPosition.posY;
        if (Move.dir == 1 && diffPos < 6f && (Input.GetKey("right") || Input.GetKey("d")) && wait >= 10)
        {
            transform.position = transform.position + cameraMove;
        }
        if (Move.dir == 0 && diffPos > -6f && (Input.GetKey("left") || Input.GetKey("a")) && wait >= 10)
        {
            transform.position = transform.position - cameraMove;
        }
        if (Input.GetKeyUp("left") || Input.GetKeyUp("a") || Input.GetKeyUp("right") || Input.GetKeyUp("d"))
        {
            wait = 0;
        }
        if (wait < 12)
        {
            wait++;
        }
        if (diffPosY > -2f && !Jump.collided && CameraPosition.posY >= floor1)
        {
            hold++;
            if (hold > 18)
            {
                transform.position = transform.position - cameraMoveDown;
                wait2 = 0;
            }
        }
        if (Jump.collided && diffPosY < 1.6f)
        {
            wait2++;
            if (wait2 >= 10)
            {
                transform.position = transform.position + cameraMoveUp;
                hold = 0;
            }
        }
        if (CameraPosition.posY < floor2)
        {
            transform.position = transform.position + new Vector3(0, .045f, 0);
        }
    }
}







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
