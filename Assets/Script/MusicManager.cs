using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicManager : MonoBehaviour
{
    // Start is called before the first frame update
    public AudioClip[] levelMusicChangeArray;
    private AudioSource audioSource;
    
    void  Awake() {
        DontDestroyOnLoad(gameObject);
        Debug.Log("Don't Destroy on Load "+name);
    }

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }
    // Update is called once per frame
    void OnLevelWasLoaded(int level)
    {
        AudioClip thisLevelMusic = levelMusicChangeArray[level];
        //Debug.Log("Playing music " +thisLevelMusic);
        if(thisLevelMusic) // If there is some music
        {
            audioSource.clip = thisLevelMusic;
            audioSource.loop = true;
            audioSource.Play();
        }
    }
}
