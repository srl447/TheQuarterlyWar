using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Start : MonoBehaviour
{
	void Update ()
    {
        if (Input.GetKey("enter") || Input.GetKey("return"))
        {
            SceneManager.LoadScene(3);
        }
	
	}
}
