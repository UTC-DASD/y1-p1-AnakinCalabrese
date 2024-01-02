using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {
	public GameObject fireball;
	public GameObject fireballstopper;
	public GameObject fireballstopper2;
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
			enterdoorspawn.gameObject.SetActive(true);
			
			Die();
			fireballstopper.gameObject.SetActive(true);
			fireballstopper2.gameObject.SetActive(true);
			
		}
	}

	void Die ()
	{
		enterdoorspawn.gameObject.SetActive(true);
		
		Instantiate(deathEffect, transform.position, Quaternion.identity);
		Destroy(gameObject);
		Instantiate(enterSign);
		fireballstopper.gameObject.SetActive(true);
	fireballstopper2.gameObject.SetActive(true);
		
		
	}
	 void Update()
    {

       
         if (health > 0)
		{
			enterdoorspawn.gameObject.SetActive(false);
			fireballstopper.gameObject.SetActive(false);
			fireballstopper2.gameObject.SetActive(false);
		}
		  if (health <= 0)
		{
			enterdoorspawn.gameObject.SetActive(true);
		}
		healthbar.SetHealth(health);
    }
private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponent<Fireballdestroy>())
        {
            Destroy(fireball);
        }else if (collision.GetComponent<PlayerControllerwithjump>())
        {
           Destroy(fireball);
        }
}}