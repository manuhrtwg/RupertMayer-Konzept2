using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reposition : MonoBehaviour
{

    private Vector3 OrigPosition;
    private float OrigRotY;
    public GameObject CollisionObject;
    private Rigidbody thisRigidbody;

    // Start is called before the first frame update
    void Start()
    {
      OrigPosition  =  transform.position;
      OrigRotY = transform.rotation.y;
      thisRigidbody = GetComponent<Rigidbody>();
    }

   void OnCollisionEnter(Collision col) {
       
       if (col.gameObject.name == CollisionObject.name) {

           transform.position = OrigPosition;
           transform.Rotate(0, OrigRotY, 0);
            thisRigidbody.velocity = Vector3.zero;
            thisRigidbody.angularVelocity = Vector3.zero;
       }
       
   }
}
