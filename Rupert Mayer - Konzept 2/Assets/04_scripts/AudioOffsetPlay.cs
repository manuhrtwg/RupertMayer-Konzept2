using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioOffsetPlay : MonoBehaviour
{   

    private AudioSource Audio;
    private float counter = 0;
    private bool alreadPlayed;

    public float AudioOffsetTime;
    // Start is called before the first frame update
    void Start()
    {
      Audio = GetComponent<AudioSource>(); 
      alreadPlayed = false; 
    }

    void OnEnable() {

        alreadPlayed = false;
        counter = 0;
    }

    // Update is called once per frame
    void Update()
    {
        

        if(counter <= AudioOffsetTime ) {
            counter = counter + Time.deltaTime; 
                       
        }

        if(counter >= AudioOffsetTime && !Audio.isPlaying && !alreadPlayed) {
               
                Audio.Play();
                alreadPlayed = true;

            }
    }
}
