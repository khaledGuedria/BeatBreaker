using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManagement : MonoBehaviour
{
    //var 
    public Text Score1;
    public Text Score2;
    public Text Score3;
    public Text Score4;
    public Text Score5;
    public Text Score6;

    public Text ChallengerName;


    // Start is called before the first frame update
    void Start()
    {

        this.loadScore(ChallengerName.text);

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //..
    public void loadScore(string name)
    {
        if (name == "Kittyplays")
        {
            Score1.text = PlayerPrefs.GetString("1_1", "0");
            Score2.text = PlayerPrefs.GetString("1_2", "0");
            Score3.text = PlayerPrefs.GetString("1_3", "0");
            Score4.text = PlayerPrefs.GetString("1_4", "0");
            Score5.text = PlayerPrefs.GetString("1_5", "0");
            Score6.text = PlayerPrefs.GetString("1_6", "0");
        }
        else if (name == "MissHarvey")
        {
            Score1.text = PlayerPrefs.GetString("2_1", "0");
            Score2.text = PlayerPrefs.GetString("2_2", "0");
            Score3.text = PlayerPrefs.GetString("2_3", "0");
            Score4.text = PlayerPrefs.GetString("2_4", "0");
            Score5.text = PlayerPrefs.GetString("2_5", "0");
            Score6.text = PlayerPrefs.GetString("2_6", "0");
        }
        else if (name == "Ant1ka")
        {
            Score1.text = PlayerPrefs.GetString("3_1", "0");
            Score2.text = PlayerPrefs.GetString("3_2", "0");
            Score3.text = PlayerPrefs.GetString("3_3", "0");
            Score4.text = PlayerPrefs.GetString("3_4", "0");
            Score5.text = PlayerPrefs.GetString("3_5", "0");
            Score6.text = PlayerPrefs.GetString("3_6", "0");
        }
        else if (name == "Xchocobars")
        {
            Score1.text = PlayerPrefs.GetString("4_1", "0");
            Score2.text = PlayerPrefs.GetString("4_2", "0");
            Score3.text = PlayerPrefs.GetString("4_3", "0");
            Score4.text = PlayerPrefs.GetString("4_4", "0");
            Score5.text = PlayerPrefs.GetString("4_5", "0");
            Score6.text = PlayerPrefs.GetString("4_6", "0");
        }
        else if (name == "Ninja")
        {
            Score1.text = PlayerPrefs.GetString("5_1", "0");
            Score2.text = PlayerPrefs.GetString("5_2", "0");
            Score3.text = PlayerPrefs.GetString("5_3", "0");
            Score4.text = PlayerPrefs.GetString("5_4", "0");
            Score5.text = PlayerPrefs.GetString("5_5", "0");
            Score6.text = PlayerPrefs.GetString("5_6", "0");
        }

    }
}
