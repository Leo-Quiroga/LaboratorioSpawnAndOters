using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    private float topBound = 30f;
    private float lowerBound = -30f;
    private float rightBound = 30f;
    private float leftBound = -30f;

    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Destruye los gameobjects cuando llegan a cierta posición en z
        if (transform.position.z > topBound || transform.position.x > rightBound)
        {
            Destroy(gameObject);
            LivesManager1.Instance.SetLives(-1);
        }
        else if (transform.position.z < lowerBound || transform.position.x < leftBound)
        {
            Destroy(gameObject);
            LivesManager1.Instance.SetLives(-1);
        }
    }
}
