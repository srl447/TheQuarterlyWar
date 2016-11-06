using UnityEngine;
using System.Collections;

public class MagazineColor : MonoBehaviour
{
    public Sprite alt1;
    public Sprite alt2;
    float color;
	// Use this for initialization
	void Start ()
    {
        color = Mathf.Floor(Random.Range(0f, 10f));
        if (color == 3)
        {
            GetComponent<SpriteRenderer>().sprite = alt1;
        }
        if (color == 4)
        {
            GetComponent<SpriteRenderer>().sprite = alt2;
        }
	}
	
	// Update is called once per frame
	void Update ()
    {
	
	}
}
