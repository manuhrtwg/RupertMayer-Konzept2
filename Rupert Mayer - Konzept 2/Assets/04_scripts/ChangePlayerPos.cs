using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangePlayerPos : MonoBehaviour
{
    
    private int PreviousScene;

    public GameObject ObjPos1;
    public GameObject ObjPos2;
    public GameObject ObjPos3;

    private Vector3 Pos1;
    private Vector3 Pos2;
    private Vector3 Pos3;



    void Start () {
        
        Pos1 = ObjPos1.transform.position;
        Pos2 = ObjPos2.transform.position;
        Pos3 = ObjPos3.transform.position;

    }

    void Awake()
    {   

        PreviousScene = PlayerPrefs.GetInt("PreviousScene");

            Debug.Log("SzenenNummer: " + PlayerPrefs.GetInt("PreviousScene"));

            if (PreviousScene == 1 ) {
                 transform.position = Pos1;
            } 
            else if (PreviousScene == 2) {
                transform.position = new Vector3 (100,0,-49);
            } 
            else if (PreviousScene == 3) {
                transform.position = new Vector3 (123,0,-50);
            }

        PlayerPrefs.SetInt("PreviousScene", 1);
       
    }

   
}
