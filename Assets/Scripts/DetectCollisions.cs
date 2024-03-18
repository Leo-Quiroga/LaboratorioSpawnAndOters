using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisions : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Pizza"))
        {
            Destroy(gameObject);
            Destroy(other.gameObject);
            ScoreManager.Instance.SetScore(1);
        }
        if (other.CompareTag("Player"))
        {
            LivesManager1.Instance.SetLives(-1);
        }
       
    }
}
