using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vida : MonoBehaviour
{
     public int VidaMaxima = 100;
    private int VidaActual;

    void Start()
    {
        VidaActual = VidaMaxima;
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
        Destroy(gameObject);
    }
}
