using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class SetPreviousSceneInt : MonoBehaviour
{
    public int CurrentScene;


    void Awake()
    {
    

    PlayerPrefs.SetInt("PreviousScene", CurrentScene );   
    }

   
}
