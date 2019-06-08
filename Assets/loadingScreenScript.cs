using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class loadingScreenScript : MonoBehaviour
{
    //var
    public goToLoaderScript loader;
    public Slider slider;
    public Text songName;

    AsyncOperation async;

    public void loadScreenAction()
    {
        StartCoroutine(loadingScreen());
    }

    //..

    IEnumerator loadingScreen()
    {
        async = SceneManager.LoadSceneAsync("SampleScene");
        async.allowSceneActivation = false;

        while(async.isDone == true)
        {

            slider.value = async.progress;
            if (async.progress == 0.9f)
            {
                slider.value = 1;
                async.allowSceneActivation = true;
            }
            yield return null;
        }
    }


    // Start is called before the first frame update
    void Start()
    {

        StartCoroutine(initializer());

    }

    IEnumerator initializer()
    {
        this.loader = FindObjectOfType<goToLoaderScript>();
        this.updateSongName();
        yield return new WaitForSeconds(5);
        SceneManager.LoadScene("SampleScene");
    }

    // Update is called once per frame
    void Update()
    {

        /*if (slider.value < 1f)
        {
            slider.value += 0.01f;
        }
        else
        {
            
            SceneManager.LoadSceneAsync("SampleScene");
        }*/
    }

    //..
    public void updateSongName()
    {
        //Level One
        if (loader.levelNumber == "1_1")
        {
            this.songName.text = "Drake - God's Plan";
        }
        if (loader.levelNumber == "1_2")
        {
            this.songName.text = "Desiigner - Tiimmy Turner";
        }
        if (loader.levelNumber == "1_3")
        {
            this.songName.text = "DJ Snake ft. Justin Bieber - Let Me Love You";
        }
        if (loader.levelNumber == "1_4")
        {
            this.songName.text = "Ariana Grande ft. Nicki Minaj - Side To Side";
        }
        if (loader.levelNumber == "1_5")
        {
            this.songName.text = "Camila Cabello ft. Young Thug - Havana";
        }
        if (loader.levelNumber == "1_6")
        {
            this.songName.text = "Major Lazer - Cold Water";
        }


        //Level Two
        if (loader.levelNumber == "2_1")
        {
            this.songName.text = "Alan Walker - Faded";
        }
        if (loader.levelNumber == "2_2")
        {
            this.songName.text = "The Chainsmokers ft. Daya - Dont Let Me Down";
        }
        if (loader.levelNumber == "2_3")
        {
            this.songName.text = "Criss Cab ft. Pharrell - Liar liar";
        }
        if (loader.levelNumber == "2_4")
        {
            this.songName.text = "Luis Fonsi - Despacito";
        }
        if (loader.levelNumber == "2_5")
        {
            this.songName.text = "Sia ft. Sean Paul - Cheap Thrills";
        }
        if (loader.levelNumber == "2_6")
        {
            this.songName.text = "Maroon 5 - Sugar";
        }



        //Level Three
        if (loader.levelNumber == "3_1")
        {
            this.songName.text = "Coldplay - A Sky Full of Stars";
        }
        if (loader.levelNumber == "3_2")
        {
            this.songName.text = "Fat Joe ft. Remy Ma French Montana Infared - All The Way Up";
        }
        if (loader.levelNumber == "3_3")
        {
            this.songName.text = "Pharrell Williams - Freedom";
        }
        if (loader.levelNumber == "3_4")
        {
            this.songName.text = "Kat Dahli - Gangsta";
        }
        if (loader.levelNumber == "3_5")
        {
            this.songName.text = "RagnBone Man - Human";
        }
        if (loader.levelNumber == "3_6")
        {
            this.songName.text = "Twenty One Pilots - Heathens";
        }


        //Level Four
        if (loader.levelNumber == "4_1")
        {
            this.songName.text = "Bruno Mars - 24k Magic";
        }
        if (loader.levelNumber == "4_2")
        {
            this.songName.text = "MAGIC! - Rude";
        }
        if (loader.levelNumber == "4_3")
        {
            this.songName.text = "Post Malone ft. Ty Dolla $ign - Psycho";
        }
        if (loader.levelNumber == "4_4")
        {
            this.songName.text = "Rae Sremmurd ft. Gucci Mane - Black Beatles";
        }
        if (loader.levelNumber == "4_5")
        {
            this.songName.text = "The Weeknd - Starboy";
        }
        if (loader.levelNumber == "4_6")
        {
            this.songName.text = "Tove Lo - Habits";
        }


        //Level Five
        if (loader.levelNumber == "5_1")
        {
            this.songName.text = "Aya Nakamura - Djadja";
        }
        if (loader.levelNumber == "5_2")
        {
            this.songName.text = "Dua Lipa - New Rules";
        }
        if (loader.levelNumber == "5_3")
        {
            this.songName.text = "Duke Dumont - Ocean Drive";
        }
        if (loader.levelNumber == "5_4")
        {
            this.songName.text = "Rihanna - We Found Love";
        }
        if (loader.levelNumber == "5_5")
        {
            this.songName.text = "Taylor Swift - Shake It Off";
        }
        if (loader.levelNumber == "5_6")
        {
            this.songName.text = "Imagine Dragons - Believer";
        }






    }

}
