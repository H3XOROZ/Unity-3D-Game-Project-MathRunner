using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPoint : MonoBehaviour
{

public Transform Spawn;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    }

    private void OnCollisionEnter(Collision other) {
        if(other.gameObject.tag =="Enemy") {
            transform.position = Spawn.position;
        }
        
    }
    
}
