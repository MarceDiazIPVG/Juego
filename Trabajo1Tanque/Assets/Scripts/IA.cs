using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI; // Importa el espacio de nombres para la navegación AI

public class IA : MonoBehaviour
{

    public NavMeshAgent agenteNavegacion; // Referencia al agente de navegación

    public Transform [] destinos; // Array de destinos para la IA

    public float distanciaFollowPath = 2f;

    private int i = 0; // Variable para controlar el índice del destino

    [Header("--------Seguimiento Jugador?--------")]

    public bool seguirJugador; // Variable para controlar si la IA sigue al jugador

    private GameObject player; // Referencia al jugador

    private float distaciaJugador; // Distancia al jugador

    public float distanciaMaxima = 10f; // Distancia máxima para seguir al jugador

    void Start()
    {
        agenteNavegacion.destination = destinos[0].transform.position; // Establece la posición del destino
                
        player= FindObjectOfType<Movimiento>().gameObject; // Encuentra el objeto del jugador en la escena
    }

    void Update()
    {
        distaciaJugador = Vector3.Distance(transform.position, player.transform.position); // Calcula la distancia al jugador
    
        if(distaciaJugador <= distanciaMaxima && seguirJugador) // Si la distancia al jugador es menor o igual a la distancia máxima
        {
            seguirJugadorMetodo();
        }
        else
        {
            EnemyPath(); // Llama a la función EnemyPath
        }
    }

    public void EnemyPath() 
    {
        agenteNavegacion.destination = destinos[i].transform.position; // Establece la posición del destino actual

        if(Vector3.Distance(transform.position, destinos[i].transform.position) <= distanciaFollowPath) // Si la distancia al destino es menor a 1
        {
            if (destinos[i] != destinos[destinos.Length - 1]) // para que respete los lugares del arreglo 
            {
                i++; // Incrementa el índice del destino
            }
            else
            {
                i = 0; // Reinicia el índice al primer destino
            }
            
        }
    }

    public void seguirJugadorMetodo()
    {
        agenteNavegacion.destination = player.transform.position; // Establece la posición del jugador como destino
    }
}
