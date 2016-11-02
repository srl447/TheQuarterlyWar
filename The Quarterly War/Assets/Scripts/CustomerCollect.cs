using UnityEngine;
using System.Collections;

public class CustomerCollect : MonoBehaviour {
    public static float totalDelivered;
    AudioSource customer;
    public AudioClip collectNoise;
    public ParticleSystem shine;
    // Use this for initialization
    void Start ()
    {
        customer = GetComponent<AudioSource>();
    }
	
	// Update is called once per frame
	void Update ()
    {
	
	}
    void OnCollisionEnter2D(Collision2D collect)
    {
        if (collect.gameObject.tag == "Magazine" || collect.gameObject.tag == "Floor-Mag")
        {
            if (GetComponent<SpriteRenderer>())
            {
                //GetComponentInParent<SpriteRenderer>().color = Color.magenta;
            }
            customer.PlayOneShot(collectNoise, 0.7F);
            Destroy(GetComponent<BoxCollider2D>());
            Destroy(GetComponentInChildren<BoxCollider2D>());
            Destroy(GetComponent<Rigidbody2D>());
            totalDelivered++;
            Animator animator = gameObject.GetComponent<Animator>();
            animator.SetTrigger("Happy");
            if(!shine.isPlaying)
            {
                shine.Play();
            }

        }
    }
}
