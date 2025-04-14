using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuDificultad : MonoBehaviour
{
    public void CargarFacil()
    {
        SceneManager.LoadScene("EscenaFacil");
    }

    public void CargarMedio()
    {
        SceneManager.LoadScene("EscenaMedia");
    }

    public void CargarDificil()
    {
        SceneManager.LoadScene("EscenaDificil");
    }
}
