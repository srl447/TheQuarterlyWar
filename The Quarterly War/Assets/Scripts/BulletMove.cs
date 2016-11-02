using UnityEngine;
using System.Collections;

public class BulletMove : MonoBehaviour {
    public float bulletSpeed;
    float extraVelocity = 1;
	// Use this for initialization
	void Start ()
    {
        if (Input.GetKey("left") || Input.GetKey("right"))
        {
            extraVelocity = 3;
        }
        if (Move.dir == 1)
        {
            GetComponent<Rigidbody2D>().AddForce(Vector3.right * bulletSpeed * extraVelocity);
        }
        if (Move.dir == 0)
        {
            GetComponent<Rigidbody2D>().AddForce(Vector3.left * bulletSpeed * extraVelocity);
        }
    }
	
	// Update is called once per frame
	void Update ()
    {

    }
}
