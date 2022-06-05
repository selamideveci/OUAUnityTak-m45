using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour
{
    public GameObject[] enemies;
    int enemyDistance = 1;

    void Start()
    {

        for (int i = 0; i < 2; i++)
        {
            GameObject enemy = Instantiate(enemies[Random.Range(1,10)], gameObject.transform.position + (transform.forward * enemyDistance) + (transform.right * Random.Range(1f, 9f)), Quaternion.Euler(0f, 180f, 0f));
            enemyDistance += 10;
            enemy.transform.parent = gameObject.transform;
        }
    }

    
    void Update()
    {
        
    }
}
