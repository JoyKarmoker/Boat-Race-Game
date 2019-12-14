using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class OptionsController : MonoBehaviour
{
    // Start is called before the first frame update
    private MusicManager musicManager;
    float volumeOfMusic;
    public Toggle toggle;

    void Start()
    {
        musicManager = GameObject.FindObjectOfType<MusicManager>();
        
        volumeOfMusic = PlayerPrefsManager.GetMasterBackgroudMusic();
        Debug.Log("Volume of music is " + volumeOfMusic);
        if(volumeOfMusic == 0f)
        {
            toggle.isOn = false;
        }

        else{
            toggle.isOn = true;
        }
    }

   /* private void Update()
    {
        if(toggle.isOn == false)
        {
            Debug.Log("Volume of music is 0");
        }
    }*/

    public void SaveAndExit()
    {
        if(toggle.isOn)
        {
           PlayerPrefsManager.SetMasterBackgroudMusic(1f);
           Debug.Log("SAve and exit button pressed, volume is 1");
           SceneManager.LoadScene("01a Start");

        }
        else
        {
           PlayerPrefsManager.SetMasterBackgroudMusic(0f);
           Debug.Log("SAve and exit button pressed, volume is 0");
           SceneManager.LoadScene("01a Start");

        }
    }

    /*public void Save(bool IsMusicOn)
    {
        if(IsMusicOn)
        {
            PlayerPrefsManager.SetMasterBackgroudMusic(1f);
        }
        else
        {
            PlayerPrefsManager.SetMasterBackgroudMusic(0f);
        }
    }*/
}
