using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwipeDetector : MonoBehaviour
{


    //var
    public float blue_hMax; 
    public float blue_hMin;
    //..
    public float red_hMax;
    public float red_hMin;

    private SaberMovement saberCtrl;


    private readonly Vector2 mXAxis = new Vector2(1, 0);
    private readonly Vector2 mYAxis = new Vector2(0, 1);

    // The angle range for detecting swipe
    private const float mAngleRange = 30;

    // To recognize as swipe user should at lease swipe for this many pixels
    private const float mMinSwipeDist = 50.0f;

    // To recognize as a swipe the velocity of the swipe
    // should be at least mMinVelocity
    // Reduce or increase to control the swipe speed
    private const float mMinVelocity = 20.0f;

    private Vector2 mStartPosition;
    private Vector2 mEndPosition;
    private float mSwipeStartTime;

    // Start is called before the first frame update
    void Start()
    {
        this.saberCtrl = GameObject.FindGameObjectWithTag("Player").GetComponentInChildren<SaberMovement>();
        
    }

    // Update is called once per frame
    void Update()
    {
        //this.swipeAction();        
    }



    //-----------------------------------------



    //Swipe Actions
    public string swipeAction()
    {

        string toExport = "";

        // Mouse button down, possible chance for a swipe
        if (Input.GetMouseButtonDown(0))
        {
            // Record start time and position
            mStartPosition = new Vector2(Input.mousePosition.x,
                                         Input.mousePosition.y);
            mSwipeStartTime = Time.time;
        }

        // Mouse button up, possible chance for a swipe
        if (Input.GetMouseButtonUp(0))
        {
            float deltaTime = Time.time - mSwipeStartTime;

            Vector2 endPosition = new Vector2(Input.mousePosition.x,
                                               Input.mousePosition.y);
            this.mEndPosition = endPosition;
            Vector2 swipeVector = endPosition - mStartPosition;

            float velocity = swipeVector.magnitude / deltaTime;

            if (velocity > mMinVelocity &&
                swipeVector.magnitude > mMinSwipeDist)
            {
                // if the swipe has enough velocity and enough distance

                swipeVector.Normalize();

                float angleOfSwipe = Vector2.Dot(swipeVector, mXAxis);
                angleOfSwipe = Mathf.Acos(angleOfSwipe) * Mathf.Rad2Deg;


                // Detect left and right swipe
                if (angleOfSwipe < mAngleRange)
                {
                    toExport = OnSwipeRight();
                }
                else if ((180.0f - angleOfSwipe) < mAngleRange)
                {
                    toExport = OnSwipeLeft();
                }
                else
                {
                    // Detect top and bottom swipe
                    angleOfSwipe = Vector2.Dot(swipeVector, mYAxis);
                    angleOfSwipe = Mathf.Acos(angleOfSwipe) * Mathf.Rad2Deg;

                    if (angleOfSwipe < mAngleRange)
                    {
                        toExport = OnSwipeTop();
                    }
                    else if ((180.0f - angleOfSwipe) < mAngleRange)
                    {
                        toExport = OnSwipeBottom();
                    }
                    else
                    {
                        toExport = "Unrecognized Swipe";
                    }
                }
            }
        }


        return toExport;
    }


    private string OnSwipeLeft()
    {
        return "left" + " - " + this.sideDetector();
    }

    private string OnSwipeRight()
    {
        return "right" + " - " + this.sideDetector();
    }

    private string OnSwipeTop()
    {
        return "top" + " - " + this.sideDetector();
    }

    private string OnSwipeBottom()
    {
        return "bottom" + " - " + this.sideDetector();
    }

    //..
    public string sideDetector()
    {
        if (this.mStartPosition.x <= blue_hMin   &&   blue_hMax <= this.mStartPosition.x &&
              this.mEndPosition.x <= blue_hMin  && blue_hMax  <= this.mEndPosition.x  )
        {
            return "left";
        }

        else if (red_hMin <= this.mStartPosition.x && this.mStartPosition.x <= red_hMax &&
            red_hMin <= this.mEndPosition.x && this.mEndPosition.x <= red_hMax)
        {
            return "right";
        }

        return "Ambigous";        
    }

}
