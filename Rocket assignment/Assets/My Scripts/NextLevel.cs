using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class NextLevel : MonoBehaviour
{

    void OnTriggerEnter(Collider other)
    {
        SceneManager.LoadScene("level 2 Rocket assignment");

        if (SceneManager.GetActiveScene().buildIndex == 1)
        {
            SceneManager.LoadScene("Rocket assignment Tibo Van der Sanden");
        }
    }
}
