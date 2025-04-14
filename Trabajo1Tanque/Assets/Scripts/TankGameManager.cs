using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro; // Asegúrate de tener esto si usas TextMeshPro

public class TankGameManager : MonoBehaviour
{
    public int score = 0;
    public TextMeshProUGUI textoPuntuacion; // Referencia al texto UI

    void Start()
    {
        int lastScore = PlayerPrefs.GetInt("Puntuacion", 0);
        Debug.Log("Última puntuación: " + lastScore);

        if (textoPuntuacion != null)
        {
            textoPuntuacion.text = "Puntuación: 0";
        }

        StartCoroutine(ActualizarScoreCada3Segundos());
    }

    public void IncreaseScore()
    {
        score++;
        PlayerPrefs.SetInt("Puntuacion", score);

        if (textoPuntuacion != null)
        {
            textoPuntuacion.text = "Puntuación: " + score;
        }
    }

    IEnumerator ActualizarScoreCada3Segundos()
    {
        while (true)
        {
            Debug.Log("Puntuación actual: " + score);
            yield return new WaitForSeconds(3f);
        }
    }
}
