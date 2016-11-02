using UnityEngine;
using System.Collections;

public class DirtyMagazine : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "Floor" || coll.gameObject.tag == "Floor-Mag")
        {
            gameObject.tag = "Floor-Mag";
            //gameObject.GetComponent<Renderer>().material.color = Color.grey;
            //Debug.Log("Dirt");
        }
    }
}
