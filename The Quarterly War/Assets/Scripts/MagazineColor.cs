using UnityEngine;
using System.Collections;

public class MagazineColor : MonoBehaviour
{
    public Sprite alt1;
    public Sprite alt2;
    public Sprite alt3;
    public Sprite alt4;
    public Sprite alt5;
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
        if (color == 5)
        {
            GetComponent<SpriteRenderer>().sprite = alt3;
        }
        if (color == 6)
        {
            GetComponent<SpriteRenderer>().sprite = alt4;
        }
        if (color == 7)
        {
            GetComponent<SpriteRenderer>().sprite = alt5;
        }
    }
	
	// Update is called once per frame
	void Update ()
    {
	
	}
}
