using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class FireballSpawner : MonoBehaviour
{
  [SerializeField] private float spawnRate = 1f;
  [SerializeField] private GameObject[] Fireball;
  [SerializeField] private GameObject[] enemyPrefabs;
[SerializeField] private bool canSpawn = true;
private void Start() {
 StartCoroutine(Spawner());
}

    private void StartCoroutine(IEnumerable enumerable)
    {
        throw new System.NotImplementedException();
    }

    private IEnumerable Spawner (){
    WaitForSeconds wait = new WaitForSeconds(spawnRate);

    while (canSpawn) {
        yield return wait;

int rand = Random.Range(0, Fireball.Length);
GameObject FireballToSpawn = Fireball[rand];

        Instantiate(FireballToSpawn, transform.position, Quaternion.identity);
    }
}
}
