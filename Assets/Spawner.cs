using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject[] cubes;
    public Transform[] points;

    private float beat;
    private float timer;

    private float note;
    private SpectrumAnalyse spectrum;


    // Start is called before the first frame update
    void Start()
    {
        this.beat = 1;
        this.spectrum = Camera.main.GetComponent<SpectrumAnalyse>();
    }

    // Update is called once per frame
    void Update()
    {

        this.note = this.spectrum.AnalyzeSound();

        if (timer > beat)
        {
            /*if (this.note > 150)
            {

                GameObject cube = Instantiate(cubes[Random.Range(0, 2)], points[Random.Range(0, 2)]);
                cube.transform.localPosition = Vector3.zero;
                //cube.transform.Rotate(transform.forward, 90 * Random.Range(0, 4));
                //..
                GameObject cube2 = Instantiate(cubes[Random.Range(2, 4)], points[Random.Range(2,4)]);
                cube2.transform.localPosition = Vector3.zero;
                //cube2.transform.Rotate(transform.forward, 90 * Random.Range(0, 4));
                timer -= beat;
            }*/
            //----------------------------------------------------------------------------
           // else
            //{

                int rdm = Random.Range(0,2);
                if (rdm == 0)
                {
                    GameObject cube = Instantiate(cubes[Random.Range(0, 2)], points[Random.Range(0, 2)]);
                    cube.transform.localPosition = Vector3.zero;
                    //cube.transform.Rotate(transform.forward, 90 * Random.Range(0, 4));
                    timer -= beat;
                }
                else
                {
                    GameObject cube = Instantiate(cubes[Random.Range(2,4)], points[Random.Range(2,4)]);
                    cube.transform.localPosition = Vector3.zero;
                    //cube.transform.Rotate(transform.forward, 90 * Random.Range(0, 4));
                    timer -= beat;
                }

            //}



        }

        timer += Time.deltaTime;
    }
}
