using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playerhealth : MonoBehaviour
{
	[SerializeField] private Cooldown cooldown;
   public int health;
   public GameObject deathEffect;
   public int maxHealth= 10;
    void Start()
    {
        health=maxHealth;
    }

public void TakeDamage(int amount)
{
health -= amount;
		if (health <= 0)
		{
			if (cooldown.IsCoolingDown) return;
			Die();
		}
	}

	void Die ()
	{
		Instantiate(deathEffect, transform.position, Quaternion.identity);
		Destroy(gameObject);
		cooldown.StartCooldown();
	}

}