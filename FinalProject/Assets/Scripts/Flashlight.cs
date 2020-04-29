using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flashlight : MonoBehaviour
{
	private float intensityDecreasePerSec = 0.1f; // intensity goes down by 1.0 every 5 seconds
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    	GetComponent<Light>().intensity -= Time.deltaTime * intensityDecreasePerSec;
    }
}
