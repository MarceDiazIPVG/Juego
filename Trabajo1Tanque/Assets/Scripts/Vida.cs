using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vida : MonoBehaviour
{
     public int VidaMaxima = 100;
    private int VidaActual;

    private TankGameManager gameManager;

    void Start()
    {
        VidaActual = VidaMaxima;
        gameManager = FindObjectOfType<TankGameManager>();
    }

    public void Daño(int dañoRecibido)
    {
        VidaActual -= dañoRecibido;

        if (VidaActual <= 0)
        {
            Muerte();
        }
    }

    void Muerte()
    {
        if (gameManager != null)
        {
            gameManager.IncreaseScore(); // Aumenta la puntuación
        }

        Destroy(gameObject);
    }
}
