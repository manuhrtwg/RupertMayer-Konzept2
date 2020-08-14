using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagement : MonoBehaviour
{
   
   public static SceneManagement Instance = null;

   public GameObject Player;

 


   public int SceneNumber = 0;
   private int CurrentScene;


    void Awake()
    {   if (Instance == null) {
        
        DontDestroyOnLoad(gameObject);
        Instance = this;

    } else if (Instance != null) {

        Destroy(gameObject);

    }
        

        

        Debug.Log("CurrentScene: " + CurrentScene);
        Player = GameObject.FindGameObjectWithTag("VRTKCameraRig");

        if (CurrentScene == 0) {
            
             if (SceneNumber == 1) {
            Player.transform.position = new Vector3(-94,-11,73);
             }
             if (SceneNumber == 2) {
            Player.transform.position = new Vector3 (30,-11,50);
             }

        } 

       
    }

    void Update () {

        CurrentScene = SceneManager.GetActiveScene().buildIndex;
    }

public void getDestinationScene(int DestScene) {

        SceneNumber = DestScene;

}
    
}
