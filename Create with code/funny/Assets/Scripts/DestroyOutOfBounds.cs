using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    private float topBound=30;
    private float bottomBound=-10;
    private float ceilingBound =15;
    private float floorBound=0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.z > topBound)
        {
            Destroy (gameObject);
        } else if(transform.position.z< bottomBound)
        {
            Debug.Log("Game Over!");
            Destroy (gameObject);
        } else if(transform.position.y>ceilingBound)
        {
            Destroy (gameObject);
        } else if(transform.position.y<floorBound)
        {
            Destroy (gameObject);
        }
       }
}
