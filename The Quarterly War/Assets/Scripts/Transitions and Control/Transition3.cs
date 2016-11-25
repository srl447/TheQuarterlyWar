using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Transition3 : MonoBehaviour
{
    int timer;
    // Use this for initialization
    void Start()
    {
        timer = 0;
        /* CameraMove.floor1 = -3;
        CameraMove.floor2 = -3.1f;*/
    }

    // Update is called once per frame
    void Update()
    {
        timer++;
        if (timer == 220)
        {
            SceneManager.LoadScene(8);
        }

    }
}
