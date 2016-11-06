using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Transition2 : MonoBehaviour
{
    int timer;
    // Use this for initialization
    void Start()
    {
        timer = 0;
    }

    // Update is called once per frame
    void Update()
    {
        timer++;
        if (timer == 130)
        {
            SceneManager.LoadScene(7);
        }

    }
}
