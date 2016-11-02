using UnityEngine;
using System.Collections;

public class Shoot : MonoBehaviour
{
    public GameObject bullet;
    public Vector3 bulletDistance;
    AudioSource magazine;
    public AudioClip shootNoise;
    // Use this for initialization
    void Start ()
    {
        magazine = GetComponent<AudioSource>();
    }
	
	// Update is called once per frame
	void Update ()
    {
        if (Input.GetKeyDown("z") || Input.GetKeyDown ("[1]"))
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
        }
	
	}
}
