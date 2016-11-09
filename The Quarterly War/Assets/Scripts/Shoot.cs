using UnityEngine;
using System.Collections;

public class Shoot : MonoBehaviour
{
    public GameObject bullet;
    public Vector3 bulletDistance;
    AudioSource magazine;
    public AudioClip shootNoise;
    int shootCooldown;
    // Use this for initialization
    void Start ()
    {
        magazine = GetComponent<AudioSource>();
        shootCooldown = 10;
    }
	
	// Update is called once per frame
	void Update ()
    {
        if (shootCooldown > 8 && (Input.GetKeyDown("z") || Input.GetKeyDown ("p")))
        {
            GameObject newBullet = Instantiate(bullet) as GameObject;
            magazine.PlayOneShot(shootNoise, .8f);
            if (Move.dir == 1)
            {
                bulletDistance.y = -1;
                newBullet.transform.position = transform.position + bulletDistance;
            }
            if (Move.dir == 0)
            {
                bulletDistance.y = 1;
                newBullet.transform.position = transform.position - bulletDistance;
            }
            shootCooldown = 0;
        }
        shootCooldown++;
	
	}
}
