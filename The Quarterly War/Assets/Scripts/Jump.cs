using UnityEngine;
using System.Collections;

public class Jump : MonoBehaviour
{
    public static bool collided;
    public float jumpHeight;
    bool hasJump;
    bool isJumping;
    //bool playJump;
    public float maxHeight;
    public float playerVelocity;
    public float drag;
    public float removeFloat;
    public AudioClip jumpNoise;
    public AudioClip land;
    AudioSource feet;
    //bool keyPress = false;
    bool keyHold = false;
    bool keyRelease = false;
    // Use this for initialization
    void Start()
    {
        collided = true;
        hasJump = true;
        isJumping = false;
        //playJump = true;
        feet = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if ((Input.GetKeyDown("space") || Input.GetKeyDown("up") || Input.GetKeyDown("w") || Input.GetKeyDown("o")) && hasJump)
        {
            isJumping = true;
            //keyPress = true;
            if (hasJump)
            {
                feet.Play();
            }
            hasJump = false;
        }
        if (Input.GetKeyUp("space") || Input.GetKeyUp("up") || Input.GetKeyUp("w") || Input.GetKeyUp("o"))
        {
            isJumping = false;
            keyRelease = true;
        }
        if (Input.GetKey("space") || Input.GetKey("up") || Input.GetKey("w") || Input.GetKey("o"))
        {
            keyHold = true;
        }
        else
        {
            //keyPress = false;
            keyHold = false;
            keyRelease = false;
        }
    }
    void FixedUpdate()
    {
        //bool keyPress = false;
        //bool keyHold = false;
        if ((Input.GetKeyDown("space") || Input.GetKeyDown("up") || Input.GetKeyDown("w") || Input.GetKeyDown("o")) && hasJump)
        {
            isJumping = true;
            //keyPress = true;
            if (hasJump)
            {
                feet.Play();
            }
            hasJump = false;
        }
        if (Input.GetKeyUp("space") || Input.GetKeyUp("up") || Input.GetKeyUp("w") || Input.GetKeyUp("o"))
        {
            isJumping = false;
            keyRelease = true;
        }
        if (Input.GetKey("space") || Input.GetKey("up") || Input.GetKey("w") || Input.GetKey("o"))
        {
            keyHold = true;
        }
        else
        {
            //keyPress = false;
            keyHold = false;
        }
        Animator animator = gameObject.GetComponent<Animator>();
        playerVelocity = GetComponent<Rigidbody2D>().velocity.y;
        if (isJumping)
        {
            /*if (hasJump && keyPress)
            {
                //audio.PlayOneShot(jumpNoise, .7f);
                feet.Play();
                animator.SetTrigger("Jump");
            }*/
            if (playerVelocity < maxHeight && keyHold)
            {
                GetComponent<Rigidbody2D>().AddForce(Vector3.up * jumpHeight);
            }
            if (playerVelocity >= maxHeight)
            {
                isJumping = false;
                animator.SetTrigger("Stop");
                GetComponent<Rigidbody2D>().AddForce(Vector3.down * removeFloat);
            }
            if (!isJumping && keyRelease)
            {
                GetComponent<Rigidbody2D>().AddForce(Vector3.down * removeFloat);
                isJumping = false;
                animator.SetTrigger("Stop");

            }
        }
    }
    void OnCollisionEnter2D (Collision2D coll)
    {
        if (coll.gameObject.tag == "Floor" || coll.gameObject.tag == "Floor-Mag" || coll.gameObject.tag == "Platform")
        {
            hasJump = true;
            //playJump = true;
            feet.PlayOneShot(land, 1f);
            GetComponent<Rigidbody2D>().drag = 0;
        }
        if (coll.gameObject.tag == "Ceiling")
        {
            isJumping = false;
        }
        if (coll.gameObject.tag == "Floor")
        {
            collided = true;
        }
    }

    void OnCollisionExit2D (Collision2D noJump)
    {
        if (noJump.gameObject.tag == "Floor" || noJump.gameObject.tag == "Platform")
        {
            GetComponent<Rigidbody2D>().drag = drag;
        }
        collided = false;
    }
}