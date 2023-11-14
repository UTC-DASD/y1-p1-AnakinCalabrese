using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {
public GameObject enterdoorspawn;
	public int health = 100;

	public GameObject deathEffect;
	public GameObject enterSign;

	public void TakeDamage (int damage)
	{
		health -= damage;

		if (health <= 0)
		{
			Die();
		}
	}

	void Die ()
	{
		Instantiate(deathEffect, transform.position, Quaternion.identity);
		Destroy(gameObject);
		Instantiate(enterdoorspawn);
		Instantiate(enterSign);
	}
	 void Update()
    {

       
         if (health > 0)
		{
			Destroy(enterdoorspawn);
		}
    }

}