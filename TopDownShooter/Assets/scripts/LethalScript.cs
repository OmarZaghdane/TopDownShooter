using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LethalScript : MonoBehaviour
{
    public float damage;
    public string enemyTag;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == enemyTag)
        {
            collision.gameObject.GetComponent<HealthManager>().TakeDamage(damage);
        }
    }
}
