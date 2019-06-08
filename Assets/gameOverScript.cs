using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gameOverScript : MonoBehaviour
{
    public void tryAgain()
    {
        SceneManager.LoadScene("SampleScene");

    }
    //..
    public void Continue()
    {
        SceneManager.LoadScene("LevelsScene");

    }
}
