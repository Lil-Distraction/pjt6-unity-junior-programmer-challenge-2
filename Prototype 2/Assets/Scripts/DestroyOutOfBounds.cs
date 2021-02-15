using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    private float topBounds = 30;
    private float lowerBounds = -10;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //When the pizza hits/crosses the top boundary it is destroyed/removed from the scene
        if (transform.position.z > topBounds)
        {
            Destroy(gameObject);
        }

        //When the animals crosses lower boundary it is destroyed/removed from the scene
        else if(transform.position.z < lowerBounds)
        {
            Debug.Log("Game Over!");  //Shows a 'Game Over!' message whenever animal hits the lower boundary
            Destroy(gameObject);
        }
    }
}
