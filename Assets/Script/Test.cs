using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(PlayerPrefsManager.GetMasterBackgroudMusic());
        PlayerPrefsManager.SetMasterBackgroudMusic(1);
        Debug.Log(PlayerPrefsManager.GetMasterBackgroudMusic());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
