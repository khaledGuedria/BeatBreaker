using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rightSaberController : MonoBehaviour
{
    //var
    public float saberSpeed;

    // Start is called before the first frame update
    void Start()
    {
        this.saberSpeed = 25;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position -= Time.deltaTime * transform.right * this.saberSpeed;
    }
}
