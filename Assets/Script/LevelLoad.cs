using System.Collections;
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

    public void instructionButton()
    {
        
        LoadNextScene("01c Instruction");
    }
    public void aboutUsButton()
    {
        
        LoadNextScene("01d About Us");
    }

    public void HomeButton()
    {
        LoadNextScene("01a Start");
    }
    public void quitButton()
    {
        
         Application.Quit();;
    }

}
