using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalaImpacto : MonoBehaviour
{
    // Valor del daño que aplica la bala
    public int damage = 10;

    private void OnCollisionEnter(Collision collision)
    {
        // Verifica si la bala colisiona con un objeto etiquetado como "Enemigo"
        if (collision.gameObject.CompareTag("Enemigo"))
        {
            // Intenta obtener el componente EnemyHealth del enemigo
            Vida enemyHealth = collision.gameObject.GetComponent<Vida>();

            // Si el componente existe, aplica el daño
            if (enemyHealth != null)
            {
                enemyHealth.Daño(damage);
            }
            else
            {
                // En caso de que el enemigo no tenga un componente de salud, se destruye directamente
                Destroy(collision.gameObject);
            }

            // Destruye la bala tras el impacto (para evitar colisiones múltiples)
            Destroy(gameObject);
        }
    }
}

