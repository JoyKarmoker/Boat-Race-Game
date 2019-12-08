using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SliderControl : MonoBehaviour
{
    // Start is called before the first frame update
    public static bool levelOnewasLoadded = false;
    int currentSceneIndex;
    public Slider slider;
    void Start()
    {
        currentSceneIndex = SceneManager.GetActiveScene().buildIndex;

        if(currentSceneIndex == 0)
        {   
            StartCoroutine("LoadSlide");
            
        }

       
    }

     IEnumerator LoadSlide() {
         int count = 0;
        for(count = 0; count<=3; count++)
        {
            slider.value = count+1;
            yield return new WaitForSeconds(1f);
        }

         levelOnewasLoadded = true;
         SceneManager.LoadScene("01a Start");
     }
}
