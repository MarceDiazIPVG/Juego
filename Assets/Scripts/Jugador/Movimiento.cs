using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento : MonoBehaviour
{

    public CharacterController controller; // Referencia al controlador de personaje
    public float velocidad = 10f; // Velocidad de movimiento

    public float gravedad = -9.81f; // Gravedad



    public Transform CheckSuelo; // Referencia al objeto que verifica el suelo
    public float radioEsfera = 0.3f; // Radio de la esfera para verificar el suelo

    public LayerMask capaSuelo; // Capa del suelo
    bool esSuelo; // Verifica si el personaje está en el suelo

    Vector3 velocidadActual; // Velocidad actual del personaje
    void Update()
    {

        esSuelo = Physics.CheckSphere(CheckSuelo.position, radioEsfera, capaSuelo); // Verifica si el personaje está en el suelo
        if (esSuelo && velocidadActual.y < 0) // Si está en el suelo
        {
            velocidadActual.y = -2f; // Establece la velocidad vertical a -2
        }
    
        
        float horizontal = Input.GetAxis("Horizontal"); // Movimiento horizontal (A/D o Izquierda/Derecha)
        float vertical = Input.GetAxis("Vertical"); // Movimiento vertical (W/S o Arriba/Abajo)

        Vector3 movimiento = transform.right * horizontal + transform.forward * vertical; // Vector de movimiento

        controller.Move(movimiento* velocidad * Time.deltaTime); // Mueve el controlador de personaje

        velocidadActual.y += gravedad * Time.deltaTime; // Aplica la gravedad a la velocidad actual

        controller.Move(velocidadActual * Time.deltaTime); // Mueve el controlador de personaje con la gravedad aplicada

    }
}
