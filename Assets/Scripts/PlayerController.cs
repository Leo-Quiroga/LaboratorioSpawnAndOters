using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class PlayerController : MonoBehaviour
{
    public float horizontalInput;
    public float speed = 10f;
    [SerializeField] private float xRange = 15f;

    public GameObject projectilePrefab;
    // Start is called before the first frame update
    void Start()
    {
        //projectilePrefab = GameObject.Find("Food");
    }

    // Update is called once per frame
    void Update()
    {
        //Payer Move
        if (transform.position.x < -xRange )
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }else if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }

        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        //Vector3 movment = new Vector3(horizontalInput, 0, verticalInput);

        //
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);
        transform.Translate(Vector3.forward * verticalInput * Time.deltaTime * speed);

        //Launch a projectile from Player
        if (Input.GetKeyDown(KeyCode.Space))
        {
           Instantiate(projectilePrefab, transform.position,projectilePrefab.transform.rotation);
        }
    }
}
