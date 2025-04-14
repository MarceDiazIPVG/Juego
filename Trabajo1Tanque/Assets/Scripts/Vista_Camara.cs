using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vista_Camara : MonoBehaviour
{

    public float sensibilidad = 80f; // Sensibilidad del ratón
    public Transform playerBody; // Referencia al objeto del jugador
     float rotacionX = 0f; // Rotación en el eje X

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked; // Bloquea el cursor en el centro de la pantalla
    }

    void Update()
    {

    float mouseX = Input.GetAxis("Mouse X") * sensibilidad * Time.deltaTime; //Movimiento del ratón en el eje X horizontal

    float mouseY = Input.GetAxis("Mouse Y") * sensibilidad * Time.deltaTime;// Movimiento del ratón en el eje Y vertical

    rotacionX -= mouseY; // Resta el movimiento del ratón en el eje Y a la rotación en el eje X

    rotacionX = Mathf.Clamp(rotacionX, -90f, 90f); // Limita la rotación en el eje X entre -90 y 90 grados

    transform.localRotation = Quaternion.Euler(rotacionX, 0f, 0f); // Rotación de la cámara en el eje X

    playerBody.Rotate(Vector3.up * mouseX); // Rotación del objeto del jugador en el eje Y


    }
}
