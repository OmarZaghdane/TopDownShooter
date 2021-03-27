using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public GameObject BulletPrefab;
    public Transform firePoint;

    public float BuletForce = 3f;
    public float shootDelay = .5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            InvokeRepeating("Shoot", 0, shootDelay);
        }
        if (Input.GetMouseButtonUp(0))
        {
            CancelInvoke("Shoot");
        }
    }

    void Shoot()
    {
        GameObject bullet = Instantiate(BulletPrefab, firePoint.position, firePoint.rotation);

        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
        rb.AddForce(firePoint.up * BuletForce, ForceMode2D.Impulse);
        Destroy(bullet, 5f);
    }
    
}
