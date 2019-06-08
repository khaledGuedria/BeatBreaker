using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Movement : MonoBehaviour
{

    public float cubesSpeed;
    public GameObject explosionPrefab;

    private GameManagement gameManager;


    // Start is called before the first frame update
    void Start()
    {
        this.cubesSpeed = 5;
        gameManager = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManagement>();

    }

    // Update is called once per frame
    void Update()
    {
        transform.position -= Time.deltaTime * transform.forward * this.cubesSpeed;
    }


    //collision detection
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "VerticalBlueSaber" && transform.gameObject.tag == "VerticalBlue")
        {
            Debug.Log("VerticalBlue");
            Instantiate(explosionPrefab, transform.position, transform.rotation);
            Destroy(gameObject);
            //Score
            gameManager.score += 100;
            this.upgradeCoeff(gameManager.score);

        }
        else if (other.tag == "VerticalRedSaber" && transform.gameObject.tag == "VerticalRed")
        {
            Debug.Log("VerticalRed");
            Instantiate(explosionPrefab, transform.position, transform.rotation);
            Destroy(gameObject);
            //Score
            gameManager.score += 100;
            this.upgradeCoeff(gameManager.score);
        }
        else if (other.tag == "HorizontalBlueSaber" && transform.gameObject.tag == "HorizontalBlue")
        {
            Debug.Log("HorizontalBlue");
            Instantiate(explosionPrefab, transform.position, transform.rotation);
            Destroy(gameObject);
            //Score
            gameManager.score += 100;
            this.upgradeCoeff(gameManager.score);
        }
        else if (other.tag == "HorizontalRedSaber" && transform.gameObject.tag == "HorizontalRed")
        {
            Debug.Log("HorizontalRed");
            Instantiate(explosionPrefab, transform.position, transform.rotation);
            Destroy(gameObject);
            //Score
            gameManager.score += 100;
            this.upgradeCoeff(gameManager.score);
        }
        else
        {
            //Debug.Log("Error ...");
        }

    }

    //..
    public void upgradeCoeff(int score)
    {
        if (score >= 1000)
        {
            this.gameManager.coeff++;
        }
        else if (score >= 5000)
        {

            this.gameManager.coeff++;
        }
        else if (score >= 10000)
        {

            this.gameManager.coeff++;
        }
        else if (score >= 20000)
        {

            this.gameManager.coeff++;
        }
        else if (score >= 50000)
        {

            this.gameManager.coeff++;
        }



    }
}
