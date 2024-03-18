using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LivesManager1 : MonoBehaviour
{
    // Instancia Singleton de LivesManager
    private static LivesManager1 instance;
    // Propiedad estática para acceder a la instancia Singleton
    public static LivesManager1 Instance
    {
        get
        {
            // Si la instancia aún no ha sido creada, la encuentra en la escena
            if (instance == null)
            {
                instance = FindObjectOfType<LivesManager1>();
            }
            // Retorna la instancia existente
            return instance;
        }
    }

    private float livesPlayer;
    [SerializeField]private GameObject player;
    private bool gameOver = false;


    // Start is called before the first frame update
    void Start()
    {
        livesPlayer = 3f;
        Debug.Log("Player's lives = " + livesPlayer);
        player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        ControlLives();
    }

    void ControlLives()
    {
        if(livesPlayer <= 0 && !gameOver)
        {
            Time.timeScale = 0f;
            Debug.Log("Game Over");
            Destroy(player);
            gameOver = true;
        }
    }

    public float GetLives()
    {
        return livesPlayer;
    }

    public void SetLives(float value)
    {
        livesPlayer += value;
        Debug.Log("Player's lives = " + livesPlayer);
    }

}
