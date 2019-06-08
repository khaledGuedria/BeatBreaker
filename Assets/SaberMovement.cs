using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaberMovement : MonoBehaviour
{
    //var
    public GameObject[] blueSabers;
    public GameObject[] redSabers;
    public Transform[] lunchers;
    private SwipeDetector swipeDetector;


    // Start is called before the first frame update
    void Start()
    {
        this.swipeDetector = GameObject.FindGameObjectWithTag("SwipeDectector").GetComponent<SwipeDetector>();
    }

    // Update is called once per frame
    void Update()
    {

        string swipe = this.swipeDetector.swipeAction();
        //lunching blue sabers ...

            if (swipe == "top - left")
            {
                GameObject saber = Instantiate(blueSabers[2], lunchers[2]);
                saber.transform.localPosition = lunchers[2].transform.localPosition;
            }
            else if (swipe == "right - left")
            {
                GameObject saber = Instantiate(blueSabers[3], lunchers[3]);
                saber.transform.localPosition = lunchers[3].transform.localPosition;
            }
            else if (swipe == "bottom - left")
            {
                GameObject saber = Instantiate(blueSabers[0], lunchers[0]);
                saber.transform.localPosition = lunchers[0].transform.localPosition;
            }
            else if (swipe == "left - left")
            {
                GameObject saber = Instantiate(blueSabers[1], lunchers[1]);
                saber.transform.localPosition = lunchers[1].transform.localPosition;
            }
        
        //------------------------------------------------
        //lunching red sabers ...


            else if (swipe == "top - right")
            {
                GameObject saber = Instantiate(redSabers[2], lunchers[6]);
                saber.transform.localPosition = lunchers[6].transform.position;
            }
            else if (swipe == "right - right")
            {
                GameObject saber = Instantiate(redSabers[3], lunchers[7]);
                saber.transform.localPosition = lunchers[7].transform.localPosition;
            }
            else if (swipe == "bottom - right")
            {
                GameObject saber = Instantiate(redSabers[0], lunchers[4]);
                saber.transform.localPosition = lunchers[4].transform.localPosition;
            }
            else if (swipe == "left - right")
            {
                GameObject saber = Instantiate(redSabers[1], lunchers[5]);
                saber.transform.localPosition = lunchers[5].transform.localPosition;
            }
       

     
    }
}
