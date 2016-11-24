using UnityEngine;
using System.Collections;

public class Dust : MonoBehaviour
{
    public ParticleSystem dusty;
    Vector3 adjust = new Vector3(0, -1.8f, 0);
	// Use this for initialization
	void Start ()
    {
	
	}
	
	// Update is called once per frame
	void Update ()
    {
	
	}
    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "Floor" || coll.gameObject.tag == "Platform")
        {
            ParticleSystem newDust = Instantiate(dusty) as ParticleSystem;
            newDust.transform.position = transform.position + adjust;
        }
    }
    void OnCollisionExit2D(Collision2D col)
    {
        if (col.gameObject.tag == "Floor" || col.gameObject.tag == "Platform")
        {
            ParticleSystem newDust = Instantiate(dusty) as ParticleSystem;
            newDust.transform.position = transform.position + adjust;
        }
    }
}
