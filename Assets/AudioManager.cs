using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class AudioManager : MonoBehaviour
{
    //var 
    private AudioSource BGM;
    public Text MissedMaxTxt;
    public goToLoaderScript loader;
    public string oldScore;
    public Text scoreText;
    public int Score;
    public AudioSource secondSource;


    // Start is called before the first frame update
    void Start()
    {

        this.BGM = gameObject.GetComponent<AudioSource>();
        this.loader = FindObjectOfType<goToLoaderScript>();
        this.changeMusicByLevel(this.loader.levelNumber);
        this.changeMissedCubesTarget(this.loader.levelNumber);

        oldScore = PlayerPrefs.GetString(this.loader.levelNumber, "0");


    }

    // Update is called once per frame
    void Update()
    {
        if (!BGM.isPlaying)
        {
            Score = int.Parse(scoreText.text);

            //Save new Score on local storage
            if (this.Score > int.Parse(oldScore))
            {
                PlayerPrefs.SetString(this.loader.levelNumber, this.Score.ToString());
            }
            
            SceneManager.LoadScene("levelUp");
        }
    }

    //..
    public void changeMusic(AudioClip music)
    {

        this.BGM.Stop();
        this.BGM.clip = music;
        this.BGM.Play();
    }

    //..
    public void changeMusicByLevel(string str)
    {

            AudioClip clip = Resources.Load<AudioClip>(str);
            this.changeMusic(clip);
    }

    //Change Missed Maximum
    public void changeMissedCubesTarget(string str)
    {
        if (str.StartsWith("1"))
        {
            MissedMaxTxt.text = "/ 50";
        }
        else if (str.StartsWith("2"))
        {
            MissedMaxTxt.text = "/ 40";
        }
        else if (str.StartsWith("3"))
        {
            MissedMaxTxt.text = "/ 30";
        }
        else if (str.StartsWith("4"))
        {
            MissedMaxTxt.text = "/ 20";
        }
        else if (str.StartsWith("5"))
        {
            MissedMaxTxt.text = "/ 10";
        }
    }


}
