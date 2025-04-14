using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disparo : MonoBehaviour
{

    public Transform PuntoSpawn; // Punto de origen del disparo
    public GameObject bala; // Prefab del proyectil

    public float fuerzaDisparo = 1500f; // Fuerza del disparo
    public float tiempoRecarga = 0.5f; // Tiempo de recarga entre disparos

    private float tiempoUltimoDisparo = 0f; // Tiempo del último disparo
 
    void Update()
    {
        
        if (Input.GetButtonDown("Fire1")) 
        {

            if(Time.time >= tiempoUltimoDisparo) // Verifica si ha pasado el tiempo de recarga
            {
                
                GameObject nuevoDisparo;
                nuevoDisparo = Instantiate(bala, PuntoSpawn.position, PuntoSpawn.rotation); // Crea una nueva bala en el punto de origen

                nuevoDisparo.GetComponent<Rigidbody>().AddForce(PuntoSpawn.forward * fuerzaDisparo); // Aplica fuerza al proyectil

                tiempoUltimoDisparo = Time.time + tiempoRecarga; // Actualiza el tiempo del último disparo

                Destroy(nuevoDisparo, 2f); // Destruye la bala después de 2 segundos
            }
        }
    }
}
