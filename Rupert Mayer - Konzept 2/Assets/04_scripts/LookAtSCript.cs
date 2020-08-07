using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtSCript : MonoBehaviour
{
    // Start is called before the first frame update


    public GameObject LookAtObject;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      // this.transform.LookAt (LookAtObject.transform);  
      transform.rotation = Quaternion.LookRotation(transform.position - LookAtObject.transform.position);
    }
}
