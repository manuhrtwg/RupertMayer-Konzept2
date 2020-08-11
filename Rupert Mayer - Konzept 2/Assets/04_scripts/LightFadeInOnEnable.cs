using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightFadeInOnEnable : MonoBehaviour
{
    // Start is called before the first frame update

    private Light myLight;
    public float fadeSpeed;
    private float lightIntensity;

    void Start()
    {
     myLight = GetComponent<Light>();  
    lightIntensity = myLight.intensity;
     myLight.intensity = 0; 
    }
    void OnEnable() {

      myLight.intensity = 0;
    }
    // Update is called once per frame
    void Update()
    {
      if (myLight.intensity <= lightIntensity) {

          myLight.intensity += 1 * fadeSpeed;
      }  
    }
}
