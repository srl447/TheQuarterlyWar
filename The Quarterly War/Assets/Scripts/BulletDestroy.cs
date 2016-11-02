using UnityEngine;
using System.Collections;

public class BulletDestroy : MonoBehaviour {
    AudioSource Magazine;
    public AudioClip thud;
	// Use this for initialization
	void Start () {
        Magazine = GetComponent<AudioSource>();

    }
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnCollisionEnter2D(Collision2D destroy)
    {
        if (destroy.gameObject.tag == "Floor" || destroy.gameObject.tag == "wall")
        {
            Magazine.PlayOneShot(thud, .7f);
        }
        if (destroy.gameObject.tag == "Customer")
        {
            Destroy(gameObject);
        }
    }
}
