using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerScript : MonoBehaviour
{
    public GameObject spawnee;

    public float spawnTime;
    public float spawnDelay;
    private float spawnTimeRandom;
    private float spawnDelayRandom;

    private float OrigPosX;
    private float OrigPosZ;
    private float OrigPosY;

    private float NewPosX;
    private float NewPosY;
    private float NewPosZ;

    private Vector3 RandomPos;




    private float Randomizer;

    private float timer = 0;
    // Start is called before the first frame update
    void Start()
    {   
        OrigPosX = transform.position.x;
        OrigPosY = transform.position.y;
        OrigPosZ = transform.position.z; 
       
    }

    // Update is called once per frame

    void Update() {
        timer += Time.deltaTime;

        

        Randomizer = Random.Range(-20,20);

        NewPosX = OrigPosX + Randomizer;
        NewPosY = OrigPosY + Randomizer;
        NewPosZ = OrigPosZ + Randomizer;
        RandomPos = new Vector3 (NewPosX,OrigPosY,NewPosZ);

        spawnTimeRandom = Random.Range(spawnTime,(spawnTime+10));
        spawnDelayRandom = Random.Range(spawnDelay, (spawnDelay +10));

        if (timer > spawnDelayRandom) {

            SetNewPos();
            Spawn();
        }
        
       
    }
    public void Spawn() {
        Debug.Log("Spawned Explosion. Delay: " + spawnDelayRandom);
        Instantiate(spawnee, RandomPos, transform.rotation);
        timer = 0;
        
    }

    public void SetNewPos() {

        this.transform.position.Set(NewPosX, OrigPosY, NewPosZ);
        Debug.Log("Spawned Explosion new Position. Position:" + (OrigPosX + Randomizer));
    }


}
