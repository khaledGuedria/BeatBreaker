using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class goToLoaderScript : MonoBehaviour
{
    //..
    public string levelNumber { get; set; }
    //..
    void start()
    {
    }

    //Level One
    public void Nav1_1()
    {
        this.levelNumber = "1_1";
    }
    public void Nav1_2()
    {
        this.levelNumber = "1_2";
    }
    public void Nav1_3()
    {
        this.levelNumber = "1_3";
    }
    public void Nav1_4()
    {
        this.levelNumber = "1_4";
    }
    public void Nav1_5()
    {
        this.levelNumber = "1_5";
    }
    public void Nav1_6()
    {
        this.levelNumber = "1_6";
    }

    //Level Two
    public void Nav2_1()
    {
        this.levelNumber = "2_1";
    }
    public void Nav2_2()
    {
        this.levelNumber = "2_2";
    }
    public void Nav2_3()
    {
        this.levelNumber = "2_3";
    }
    public void Nav2_4()
    {
        this.levelNumber = "2_4";
    }
    public void Nav2_5()
    {
        this.levelNumber = "2_5";
    }
    public void Nav2_6()
    {
        this.levelNumber = "2_6";
    }

    //Level Three
    public void Nav3_1()
    {
        this.levelNumber = "3_1";
    }
    public void Nav3_2()
    {
        this.levelNumber = "3_2";
    }
    public void Nav3_3()
    {
        this.levelNumber = "3_3";
    }
    public void Nav3_4()
    {
        this.levelNumber = "3_4";
    }
    public void Nav3_5()
    {
        this.levelNumber = "3_5";
    }
    public void Nav3_6()
    {
        this.levelNumber = "3_6";
    }

    //Level Four
    public void Nav4_1()
    {
        this.levelNumber = "4_1";
    }
    public void Nav4_2()
    {
        this.levelNumber = "4_2";
    }
    public void Nav4_3()
    {
        this.levelNumber = "4_3";
    }
    public void Nav4_4()
    {
        this.levelNumber = "4_4";
    }
    public void Nav4_5()
    {
        this.levelNumber = "4_5";
    }
    public void Nav4_6()
    {
        this.levelNumber = "4_6";
    }


    //Level Five
    public void Nav5_1()
    {
        this.levelNumber = "5_1";
    }
    public void Nav5_2()
    {
        this.levelNumber = "5_2";
    }
    public void Nav5_3()
    {
        this.levelNumber = "5_3";
    }
    public void Nav5_4()
    {
        this.levelNumber = "5_4";
    }
    public void Nav5_5()
    {
        this.levelNumber = "5_5";
    }
    public void Nav5_6()
    {
        this.levelNumber = "5_6";
    }
    //-----------------------------------------------------------------------------------------
    //go to loader by level
    public void levelOneLoader()
    {
        SceneManager.LoadScene("Loader01");
    }
    //..
    public void levelTwoLoader()
    {
        SceneManager.LoadScene("Loader02");
    }
    //..
    public void levelThreeLoader()
    {
        SceneManager.LoadScene("Loader03");
    }
    //..
    public void levelFourLoader()
    {
        SceneManager.LoadScene("Loader04");
    }
    //..
    public void levelFiveLoader()
    {
        SceneManager.LoadScene("Loader05");
    }
    //..
}
