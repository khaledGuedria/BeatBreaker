using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MissesDetector : MonoBehaviour
{
    //var
    public int missedCubes = 0;
    public Text missedTargetTxt;
    public int missedTargetVal;
    public Text missedText;
    public AudioSource secondSource;

    // Start is called before the first frame update
    void Start()
    {

        missedText.text = missedCubes.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        missedText.text = missedCubes.ToString();

        var initialStr = missedTargetTxt.text;
        var stringNBR = missedTargetTxt.text.Substring(initialStr.Length - 2);
        missedTargetVal = int.Parse(stringNBR);
        if (missedCubes == missedTargetVal)
        {

           SceneManager.LoadScene("GameOver");
  
        }


    }
    //..
    private void OnTriggerEnter(Collider other)
    {

        Debug.Log(other.name);

        if (other.tag == "HorizontalRed" || other.tag == "HorizontalBlue" || other.tag == "VerticalRed" || other.tag == "VerticalBlue")
        {

            this.missedCubes++;
            Destroy(other.gameObject);

        }
    }

}
