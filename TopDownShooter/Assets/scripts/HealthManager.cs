using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthManager : MonoBehaviour
{
    public Behaviour[] disableOnDeath;
    public float Maxhealth;
    public float health;
    public Image HealthCirce;
    public bool isPlayer;

    private void Start()
    {
        health = Maxhealth;
    }


    public void TakeDamage(float amount)
    {
        health -= amount;
        if (health <= 0)
        {
            health = 0;
            Die();
        }
        if(isPlayer)
            HealthCirce.fillAmount = health / Maxhealth;
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
