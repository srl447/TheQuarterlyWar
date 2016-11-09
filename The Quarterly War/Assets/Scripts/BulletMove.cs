using UnityEngine;
using System.Collections;

public class BulletMove : MonoBehaviour {
    public float bulletSpeed;
    float extraVelocity = 1;
    public ParticleSystem smoke;
	// Use this for initialization
	void Start ()
    {
        if (Input.GetKey("left") || Input.GetKey("a") || Input.GetKey("right") || Input.GetKey("d"))
        {
            extraVelocity = 2.9f;
        }
        if (Move.dir == 1)
        {
            GetComponent<Rigidbody2D>().AddForce(Vector3.right * bulletSpeed * extraVelocity);
        }
        if (Move.dir == 0)
        {
            GetComponent<Rigidbody2D>().AddForce(Vector3.left * bulletSpeed * extraVelocity);
        }
        if (!smoke.isPlaying)
        {
            smoke.Play();
        }
    }
	
	// Update is called once per frame
	void Update ()
    {

    }
}
