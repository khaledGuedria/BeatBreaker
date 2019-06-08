using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackBtnScript : MonoBehaviour
{
    public void backAction()
    {
        SceneManager.LoadScene("LevelsScene");

    }
}
