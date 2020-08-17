using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TimeBasedSceneChange : MonoBehaviour
{
    private float Timer;
    public float OffsetTime;
    public int SceneNumber;
    public void ChangeTheScene (int ChangeToScene) {
        SceneManager.LoadScene(ChangeToScene);

    }

    void Update() {
        Timer += Time.deltaTime;

        if (Timer > OffsetTime) {

            ChangeTheScene(SceneNumber);
        }

    }
}
