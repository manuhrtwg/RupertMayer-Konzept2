using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangePlayerPos : MonoBehaviour
{
    
    private int PreviousScene;

    void Awake()
    {   

        PreviousScene = PlayerPrefs.GetInt("PreviousScene");

        

            if (PreviousScene == 1 ) {

                 transform.position = new Vector3(3,0,-3);
            } else if (PreviousScene == 2) {

                transform.position = new Vector3(94,0,-39);
            } else if (PreviousScene == 3) {

                transform.position = new Vector3(128,0,-27);
            }

        PlayerPrefs.SetInt("PreviousScene", 1);
       
    }

   
}
