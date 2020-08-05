using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayAudioDelay : MonoBehaviour
{

    private AudioSource audioPlayer;
    public float AudioDelay = 7;

    // Start is called before the first frame update
    void Start()
    {
    audioPlayer = GetComponent<AudioSource>();
    audioPlayer.PlayDelayed(AudioDelay);
    
    }

    // Update is called once per frame
    void Update()
    {
     
      
      }  
    
}
