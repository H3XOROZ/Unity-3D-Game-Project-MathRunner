using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{

    float speedX = 0;
    float speedY = 0;
    float speedZ = 3;

    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    

    transform.Translate(new Vector3(speedX,speedY,speedZ)* Time.deltaTime);
    }
}
