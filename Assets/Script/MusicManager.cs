using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicManager : MonoBehaviour
{
    // Start is called before the first frame update
    public AudioClip[] levelMusicChangeArray;
    private AudioSource audioSource;
    bool levelOnewasloaded = false;
    //public static AudioClip audioClip;
    
    void  Awake() {
        GameObject[] objs = GameObject.FindGameObjectsWithTag("Music");
        if(objs.Length>1)
        {
            levelOnewasloaded = true;
            Destroy(this.gameObject);
        }
        DontDestroyOnLoad(gameObject);
       // Debug.Log("Don't Destroy on Load "+name);
    }

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }
    // Update is called once per frame
    void OnLevelWasLoaded(int level)
    {
        if(level != 1)
        {
            levelOnewasloaded = true;
        }
        Debug.Log("Level in music Manager "+level);
        if((level==1 && levelOnewasloaded == false) || level == 4){
            AudioClip thisLevelMusic = levelMusicChangeArray[level];
            //Debug.Log("Playing music " +thisLevelMusic);
            //audioClip = thisLevelMusic;
            if(thisLevelMusic) // If there is some music
            {
                audioSource.clip = thisLevelMusic;
                audioSource.loop = true;
                audioSource.Play();
            }
        }

    }
}
