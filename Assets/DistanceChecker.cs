using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DistanceChecker : MonoBehaviour
{
    [SerializeField] float DistanceVelocity;
    [SerializeField] EnemySpawn Game;

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + new Vector3(0, -DistanceVelocity, 0) * Time.deltaTime;

        if (transform.position.y < -6)
        {
            Destroy(gameObject);
            Game.Distance += 1;
            Debug.Log(Game.Distance);
        }
    }
}
