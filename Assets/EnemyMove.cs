using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    [SerializeField] float EnemyVelocity;
    [SerializeField] EnemySpawn Game;
   
    // Update is called once per frame
    void Update()
    {
            transform.position = transform.position + new Vector3(0, -EnemyVelocity, 0) * Time.deltaTime;

        if (transform.position.y < -6)
        {
            Destroy(gameObject);
            Debug.Log("Destroyed");
        }

        if (Game.Distance > 999 && Game.Distance % 1000 == 0)
        {
            EnemyVelocity += 0.5f;
        }
    }
}
