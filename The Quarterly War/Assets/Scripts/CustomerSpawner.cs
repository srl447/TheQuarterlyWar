using UnityEngine;
using System.Collections;

public class CustomerSpawner : MonoBehaviour {
    public GameObject customer1;
    public GameObject customer2;
    public GameObject customer3;
    public GameObject customer4;
    public GameObject customer5;
    public GameObject customer6;
    public GameObject customer7;
    GameObject customer;
    public bool flip;
    float which; 
    // Use this for initialization
    void Start ()
    {
        which = Mathf.Floor(Random.Range(0f, 8f));
        if (which == 1)
        {
            customer = customer1;
        }
        else if (which == 2)
        {
            customer = customer2;
        }
        else if (which == 3)
        {
            customer = customer3;
        }
        else if (which == 4)
        {
            customer = customer4;
        }
        else if (which == 5)
        {
            customer = customer5;
        }
        else if (which == 6)
        {
            customer = customer6;

        }
        else
        {
            customer = customer7;
        }
        GameObject newCustomer = Instantiate(customer) as GameObject;
        newCustomer.transform.position = transform.position;
        if (flip)
        {
            newCustomer.GetComponent<SpriteRenderer>().flipX = true;
        }
        if(!flip)
        {
            newCustomer.GetComponent<SpriteRenderer>().flipX = false;
        }

    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
