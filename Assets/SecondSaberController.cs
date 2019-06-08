using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecondSaberController : MonoBehaviour
{
    //var 
    public float rotationSpeed;
    private Animator mAnimator;

    // Start is called before the first frame update
    void Start()
    {
        mAnimator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            mAnimator.SetTrigger("VerticalAttack");
        }
    }
}
