using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VRTK;

public class InfoOnGrabbed : MonoBehaviour
{   

    public GameObject InfoObj;

    public float MaxDistance = 1;

    public GameObject ControllerLeft;
    public GameObject ControllerRight;

    private float DistanceLeft;
    
    private float DistanceRight;
    
    void Start() {

        InfoObj.SetActive(false);

    }

    void Update() {

        DistanceLeft = Vector3.Distance(ControllerLeft.transform.position, transform.position);
        DistanceRight = Vector3.Distance(ControllerRight.transform.position, transform.position);

        if (DistanceLeft < MaxDistance || DistanceRight < MaxDistance) {

            InfoObj.SetActive(true);
        } else {

            InfoObj.SetActive(false);
        }

        Debug.Log("Distanz zum Rechten Controller: " + DistanceRight);
    }


}
