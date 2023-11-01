using System.Collections;
using System.Collections.Generic;
using System.Data;
using UnityEngine;

public class Weapon : MonoBehaviour{
[SerializeField] private Cooldown cooldown;
   public Transform firePoint;
   public GameObject fireSprite;
   public GameObject BulletPrefab;

    // Update is called once per frame
    void Update(){
        if (cooldown.IsCoolingDown) return;
    if (Input.GetButtonDown("Fire1"))
    {
        Shoot();
        cooldown.StartCooldown();
    }
        
    }
void Shoot () 
{
    
    
Instantiate(BulletPrefab,firePoint.position, firePoint.rotation);
}

}

