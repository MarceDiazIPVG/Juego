using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro; // Aseg�rate de tener esto si usas TextMeshPro

public class TankGameManager : MonoBehaviour
{
    public int score = 0;
    public TextMeshProUGUI textoPuntuacion; // Referencia al texto UI

    void Start()
    {
        int lastScore = PlayerPrefs.GetInt("Puntuacion", 0);
        Debug.Log("�ltima puntuaci�n: " + lastScore);

        if (textoPuntuacion != null)
        {
            textoPuntuacion.text = "Puntuaci�n: 0";
        }

        StartCoroutine(ActualizarScoreCada3Segundos());
    }

    public void IncreaseScore()
    {
        score++;
        PlayerPrefs.SetInt("Puntuacion", score);

        if (textoPuntuacion != null)
        {
            textoPuntuacion.text = "Puntuaci�n: " + score;
        }
    }

    IEnumerator ActualizarScoreCada3Segundos()
    {
        while (true)
        {
            Debug.Log("Puntuaci�n actual: " + score);
            yield return new WaitForSeconds(3f);
        }
    }
}
