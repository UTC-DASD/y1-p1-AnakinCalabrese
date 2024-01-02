using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireballSpawner2 : MonoBehaviour
{
    [SerializeField] private Cooldown cooldown;
    public GameObject fireball;
    public Transform firePoint;
    void Start()
    {
        
    }

    void Update()
    {
            if (cooldown.IsCoolingDown) return;

    {
        Shoot();
        cooldown.StartCooldown();
    }
    }
    void Shoot () 
{
    
    
Instantiate(fireball,firePoint.position, firePoint.rotation);
}
}
