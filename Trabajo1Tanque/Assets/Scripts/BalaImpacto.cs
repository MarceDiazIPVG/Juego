using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalaImpacto : MonoBehaviour
{
    public int damage = 10;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemigo"))
        {
            Vida enemyHealth = collision.gameObject.GetComponent<Vida>();

            if (enemyHealth != null)
            {
                enemyHealth.Daño(damage); // ❌ NO destruyas aquí
            }

            Destroy(gameObject); // Solo destruye la bala
        }
    }
}

