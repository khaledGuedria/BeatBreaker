using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dontDestroy : MonoBehaviour
{


    //Awake
    void Awake()
    {
        GameObject[] objs = GameObject.FindGameObjectsWithTag("levelMusicManager");

        if (objs.Length > 1)
        {
            Destroy(objs[0]);
        }

        DontDestroyOnLoad(this.gameObject);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
