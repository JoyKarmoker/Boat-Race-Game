﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class LevelLoad : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        
       
    }

 

     public void LoadNextScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    public void playButton()
    {
        
        LoadNextScene("02 Play");
    }

    public void settingsButton()
    {
        
        LoadNextScene("01b Settings");
    }


    public void creditsButton()
    {
        
        LoadNextScene("01c Credits");
    }

    public void HomeButton()
    {
        LoadNextScene("01a Start");
    }


    public void winButton()
    {
        LoadNextScene("03a Win");
    }

    public void LosseButton()
    {
        LoadNextScene ("03b Losse");
    }
    public void quitButton()
    {
        
         Application.Quit();;
    }

}
