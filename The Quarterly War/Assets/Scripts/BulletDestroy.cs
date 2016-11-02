using UnityEngine;
using System.Collections;

public class BulletDestroy : MonoBehaviour {
    AudioSource Magazine;
    public AudioClip thud;
    float distX;
    float distY;
	// Use this for initialization
	void Start () {
        Magazine = GetComponent<AudioSource>();

    }
	
	// Update is called once per frame
	void Update ()
    {
       distX = CameraPosition.posX - transform.position.x;
       distY = CameraPosition.posY - transform.position.y;
       if (gameObject.tag == "Magazine" && (distX > 14 || distX < -14 || distY > 7 || distY < -7))
        {
            Destroy(gameObject);
        }


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
