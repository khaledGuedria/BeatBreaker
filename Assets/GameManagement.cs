using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class GameManagement : MonoBehaviour
{
    //var 
    public Text[] canvas;
    public Text points;
    public Text coefficient;
    public AudioSource audioSource;
    public Button muteBtn;
    public Button stopBtn;
    public int score;
    public int coeff;
    public Sprite volumeSprite;
    public Sprite muteSprite;
    public Sprite playSprite;
    public Sprite stopSprite;
    public GameObject settingsPanel;

    // Start is called before the first frame update
    void Start()
    {
        this.audioSource = Camera.main.GetComponent<AudioSource>();
        this.canvas = GameObject.FindGameObjectWithTag("UICanvas").GetComponentsInChildren<Text>();
        this.points = canvas[0];
        this.score = 0;
        this.points.text = score.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        this.points.text = score.ToString();
    }


    //mute
    public void muteAction()
    {
        audioSource.mute = !audioSource.mute;

        if (audioSource.mute == true)
        {
            this.muteBtn.image.sprite = volumeSprite;
        }
        if (audioSource.mute == false)
        {
            this.muteBtn.image.sprite = muteSprite;
        }
    }


        //Pause
    public void pauseAction()
    {
        if (Time.timeScale == 1)//if not paused 
        {
            audioSource.Pause();
            Time.timeScale = 0; //then pause
            stopBtn.image.sprite = playSprite;
        }
        else
        {
            Time.timeScale = 1; //play
            audioSource.Play();
            stopBtn.image.sprite = stopSprite;


        }
    }


    //Show settingsPanel
    public void showPanel()
    {
        this.settingsPanel.SetActive(!settingsPanel.activeSelf);

        if (settingsPanel.activeSelf == true) 
        {
            audioSource.Pause();
            Time.timeScale = 0; //then pause
            stopBtn.image.sprite = playSprite;
            

        }
        else
        {
            Time.timeScale = 1; //play
            audioSource.Play();
            stopBtn.image.sprite = stopSprite;

        }
    }

    //changeLevel
    public void changeLevelAction()
    {
        SceneManager.LoadScene("LevelsScene");
    }
    //restart Level
    public void restartLevelAction()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        Time.timeScale = 1;
    }
    //Exit
    public void exitAction()
    {
        Application.Quit();
    }




}
