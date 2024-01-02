using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy1 : MonoBehaviour {
public GameObject enterdoorspawn;
	public int health = 100;
public healthbar healthbar;
	public GameObject deathEffect;
	public GameObject enterSign;
void Start()
{
	healthbar.SetMaxHealth(health);
}
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
		healthbar.SetHealth(health);
    }

}