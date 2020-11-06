using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    [SerializeField] Transform toBeCloned;
    [SerializeField] int EnemyFrequency;
    [SerializeField] Transform DistanceChecker;
    [SerializeField] TextMeshProUGUI ScoreText;
    [SerializeField] EnemyMove Enemy;

    public int Distance = 0;

    // Update is called once per frame
    void Update()
    {
        int factor = Random.Range(1, 50);
        if (factor < EnemyFrequency)
        {
            toBeCloned = Instantiate(toBeCloned, new Vector3(Random.Range(-8, 8), 6, 0), Quaternion.identity);
        }

        DistanceChecker = Instantiate(DistanceChecker, new Vector3(-12, 6, 0), Quaternion.identity);
        ScoreText.text = Distance.ToString();
    }
}
