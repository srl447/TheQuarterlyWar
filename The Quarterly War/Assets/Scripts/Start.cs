using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Start : MonoBehaviour
{
	void Update ()
    {
        if (Input.GetKey("space"))
        {
            SceneManager.LoadScene(3);
        }
	
	}
}
