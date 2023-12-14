using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public GameObject enemyPrefab;
    public float enemySpeed;
    public int health;
    void Start()
    {
        
    }

    // Update is called once per frame
    private void Update()
    {
       transform.Translate(Vector3.forward * enemySpeed * Time.deltaTime );
    }

    public void TakeDamage(int damageAmount)
    {
        health -= damageAmount;

        if (health <= 0)
        {
            Destroy(gameObject);
        }
    }

}
