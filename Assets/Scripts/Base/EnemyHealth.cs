using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class EnemyHealth : MonoBehaviour
{
    public UnityEvent EventOnTakeDamage;
    public int Health = 5;

    public void TakeDamage(int damageValue)
    {
        Health -= damageValue;
        if (Health <= 0)
        {

            Die();
        }
        EventOnTakeDamage.Invoke();

    }
    public void Die()
    {
        Destroy(gameObject);
    }
}
