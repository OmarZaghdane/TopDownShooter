using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthManager : MonoBehaviour
{
    public Behaviour[] disableOnDeath;
    public float health;
    
    public void TakeDamage(float amount)
    {
        health -= amount;
        if (health <= 0)
        {
            health = 0;
            Die();
        }
    }
    void Die()
    {
        foreach (Behaviour behaviour in disableOnDeath)
        {
            behaviour.enabled = false;
        }
        Debug.Log("dead " + gameObject.name);
    }

}
