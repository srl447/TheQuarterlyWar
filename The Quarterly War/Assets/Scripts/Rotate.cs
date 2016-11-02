using UnityEngine;
using System.Collections;

public class Rotate : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (Move.dir == 1)
        {
            GetComponent<SpriteRenderer>().flipX = false;
        }
        if (Move.dir == 0)
        {
            GetComponent<SpriteRenderer>().flipX = true;
        }

    }
}
