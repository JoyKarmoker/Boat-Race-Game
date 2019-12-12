using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPrefsManager : MonoBehaviour
{
    const string MASTER_BACKGROUNDMUSIC_KEY = "master_backgroundMusic";
    public static void SetMasterBackgroudMusic(float volume)
    {
        if(volume >=0f && volume <=1f)
        {
             PlayerPrefs.SetFloat(MASTER_BACKGROUNDMUSIC_KEY, volume);
        }
        else
        {
            Debug.LogError("Volume Out OF range");
        }
       
    }

    public static float GetMasterBackgroudMusic()
    {
       return( PlayerPrefs.GetFloat(MASTER_BACKGROUNDMUSIC_KEY));
    }
 
}
