using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Playerhealth : MonoBehaviour
{
	private string sceneToLoad;
	public GameObject entersign;
	public bool enterAllowed;
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
		
            enterAllowed = true;
			
		}
	}

	void Die ()
	{
		Instantiate(deathEffect, transform.position, Quaternion.identity);
		Destroy(gameObject);
		Instantiate(entersign);
		cooldown.StartCooldown(); 
	


	}
	
private void Update()
    {
        if (enterAllowed && Input.GetKey(KeyCode.Return))
        {
            SceneManager.LoadScene(sceneToLoad);
        }
    }

	private void OnTriggerEnter2D(Collider2D collision)
	{
        if  (enterAllowed && collision.GetComponent<GameoverDoor>())
        {
            sceneToLoad = "GameOver";
           
        }
	}
}