using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionAudio : MonoBehaviour
{
   public AudioSource ColAudio;

   void Start() {

       ColAudio = GetComponent<AudioSource>();

   }

   void OnCollisionEnter(Collision col) {
        if (col.relativeVelocity.magnitude > 1) {

            if (col.gameObject.tag != "NoAudioOnCol") {

                ColAudio.volume = col.relativeVelocity.magnitude;
                ColAudio.Play();
                
            }
            
        }

   }
}
