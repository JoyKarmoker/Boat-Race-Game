using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FadeIn : MonoBehaviour
{
    private float fadeInTime = 2f;
    private Image fadeInPanel;
    private Color currentColor = Color.black;
    // Start is called before the first frame update
    void Start()
    {
        fadeInPanel = GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Time.timeSinceLevelLoad < fadeInTime)
        {
            float alphaChange = Time.deltaTime / fadeInTime;
            currentColor.a -= alphaChange;
            fadeInPanel.color = currentColor;
        }
        else
        {
            gameObject.SetActive(false);
        }
    }
}
