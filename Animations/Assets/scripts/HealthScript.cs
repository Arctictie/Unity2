using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;


public class HealthScript : MonoBehaviour
{

    Text myText;
    public int health = 100;

    void Start()
    {
        //Text sets your text to say this message
        myText = GetComponent<Text>();
        myText.text = "Health: " + health;
    }

    void Update()
    {
        myText.text = "Health: " + health;

        if(health < 1)
        {
           
           
     
            SceneManager.LoadSceneAsync("Scenes/Menu");
        }


    }
}
