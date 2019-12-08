using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelLoad : MonoBehaviour
{
    //[SerializeField] int timetoWait = 4;
    public Slider slider;
    public Text progrssText;
    int currentSceneIndex;
    // Start is called before the first frame update
    void Start()
    {
        currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        if(currentSceneIndex == 0)
        {
            StartCoroutine(LoadAsynchronusly(currentSceneIndex));
        }
    }

    IEnumerator LoadAsynchronusly(int sceneIndex)
    {
        AsyncOperation operation = SceneManager.LoadSceneAsync(sceneIndex+1);
        while(!operation.isDone)
        {
            float progress = Mathf.Clamp01(operation.progress/0.9f);
            int percentage = (int)(progress*100);
            //Debug.Log(progress);
            slider.value = progress;
            progrssText.text = "Loading " +percentage+ "%";
            yield return null;
        }
        
        //LoadNextScene();
    }

     void LoadNextScene(int nextLevel)
    {
        SceneManager.LoadScene(nextLevel);
    }

    public void playButton()
    {
        
        LoadNextScene(2);
    }

    public void settingsButton()
    {
        
        LoadNextScene(3);
    }

    public void instructionButton()
    {
        
        LoadNextScene(4);
    }
    public void aboutUsButton()
    {
        
        LoadNextScene(5);
    }

    public void quitButton()
    {
        
         Application.Quit();;
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
