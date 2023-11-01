using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playerhealth : MonoBehaviour
{
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
			Die();
		}
	}

	void Die ()
	{
		Instantiate(deathEffect, transform.position, Quaternion.identity);
		Destroy(gameObject);
	}

}