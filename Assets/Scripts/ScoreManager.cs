using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    // Instancia Singleton de LivesManager
    private static ScoreManager instance;
    // Propiedad estática para acceder a la instancia Singleton
    public static ScoreManager Instance
    {
        get
        {
            // Si la instancia aún no ha sido creada, la encuentra en la escena
            if (instance == null)
            {
                instance = FindObjectOfType<ScoreManager>();
            }
            // Retorna la instancia existente
            return instance;
        }
    }

    int score;
    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        Debug.Log("Player's score = " + score);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public float GetScore()
    {
        return score;
    }

    public void SetScore(int value)
    {
        score += value;
        Debug.Log("Player's score = " + score);
    }
}
