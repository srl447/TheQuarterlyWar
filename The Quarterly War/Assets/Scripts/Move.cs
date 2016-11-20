using UnityEngine;
using System.Collections;

public class Move : MonoBehaviour
{
    public float runSpeed;
    public float skid;
    public static float dir;
    public float maxSpeed;
    public float playerVelocity;
    public float wallSlide;
    public GameObject timer;
    //AudioSource skates;

    // dir = 0 for left and dir = 1 for right
    // Use this for initialization
    void Start()
    {
        dir = 1;
        //skates = timer.GetComponent<AudioSource>();

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Animator animator = gameObject.GetComponent<Animator>();
        playerVelocity = GetComponent<Rigidbody2D>().velocity.x;
        if (Input.GetKey("left") || Input.GetKey("a"))
        {
            animator.SetTrigger("Walk");
            //skates.Play();
            if (playerVelocity > -maxSpeed)
            {
                GetComponent<Rigidbody2D>().AddForce(Vector3.left * runSpeed);
                dir = 0;
            }

        }
        if(Input.GetKeyUp("left") || Input.GetKeyUp("a"))
        {
            GetComponent<Rigidbody2D>().AddForce(Vector3.right * -playerVelocity * runSpeed * skid);
            //skates.Stop();
        }
        if (Input.GetKey("right") || Input.GetKey("d"))
        {
            animator.SetTrigger("Walk");
            //skates.Play();
            if (playerVelocity < maxSpeed)
            {
                GetComponent<Rigidbody2D>().AddForce(Vector3.right * runSpeed);
                dir = 1;
            }
        }
        if (Input.GetKeyUp("right") || Input.GetKeyUp("d"))
        {
            GetComponent<Rigidbody2D>().AddForce(Vector3.left * playerVelocity * runSpeed * skid);
            //skates.Stop();
        }
        if (playerVelocity < .052 && playerVelocity > -.052)
        {
            animator.SetTrigger("Stop");
        }
    }
    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "wall")
        {
            GetComponent<Rigidbody2D>().AddForce(Vector3.down * wallSlide);
        }
    }
}
