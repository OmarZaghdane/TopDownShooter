using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieStooock : MonoBehaviour
{
   public GameObject[] Zombies;
    public AudioSource Boum;
    public ParticleSystem BoumEffect;


    private void Awake()
    {
        BoumEffect.Stop();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.B))
        {
            Boum.Play();
            BoumEffect.Play();
            Bomb();
            
        }
    }

    private void Bomb()
    {
        Zombies = GameObject.FindGameObjectsWithTag("Enemy");

        foreach (GameObject z in Zombies)
        {
            Destroy(z);
            
        }
    }

}
