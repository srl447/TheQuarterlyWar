using UnityEngine;
using System.Collections;

public class Jump : MonoBehaviour
{
    public float jumpHeight;
    bool hasJump;
    bool isJumping;
    //bool playJump;
    public float maxHeight;
    public float playerVelocity;
    public float drag;
    public AudioClip jumpNoise;
    public AudioClip land;
    AudioSource feet;
    // Use this for initialization
    void Start()
    {
        hasJump = true;
        isJumping = false;
        //playJump = true;
        feet = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        Animator animator = gameObject.GetComponent<Animator>();
        playerVelocity = GetComponent<Rigidbody2D>().velocity.y;
        if (hasJump || isJumping)
        {
            if (Input.GetKey("space") || Input.GetKey("up"))
            {
                if (hasJump)
                {
                    //audio.PlayOneShot(jumpNoise, .7f);
                    feet.Play();
                    animator.SetTrigger("Jump");
                }
                isJumping = true;
                if (playerVelocity < maxHeight)
                {
                    GetComponent<Rigidbody2D>().AddForce(Vector3.up * jumpHeight);
                }
                if (playerVelocity >= maxHeight)
                {
                    hasJump = false;
                    isJumping = false;
                    animator.SetTrigger("Stop");
                }

            }
            if (Input.GetKeyUp("space") || Input.GetKeyUp("up"))
            {
                hasJump = false;
                isJumping = false;
                animator.SetTrigger("Stop");
            }
            
        }

    }
    void OnCollisionEnter2D (Collision2D coll)
    {
        if (coll.gameObject.tag == "Floor" || coll.gameObject.tag == "Floor-Mag")
        {
            hasJump = true;
            //playJump = true;
            feet.PlayOneShot(land, 1f);
            GetComponent<Rigidbody2D>().drag = 0;
        }
        if (coll.gameObject.tag == "Ceiling")
        {
            hasJump = false;
            isJumping = false;
        }
    }
    void OnCollisionExit2D (Collision2D noJump)
    {
        if (noJump.gameObject.tag == "Floor" || noJump.gameObject.tag == "Floor-Mag")
        {
            hasJump = false;
            GetComponent<Rigidbody2D>().drag = drag;
        }
    }
}