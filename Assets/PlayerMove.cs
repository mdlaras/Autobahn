using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    [SerializeField] float PlayerVelocity;
    [SerializeField] EnemySpawn Game;
    [SerializeField] TextMeshProUGUI ScoreText; 
    float Velocity;
    // Update is called once per frame

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(gameObject);
        Destroy(Game.gameObject);
        int EndDistance = Game.Distance;
        ScoreText.text = EndDistance.ToString();
    }
    private void Start()
    {
       Velocity = 0;
    }
    void Update()
    {
        
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            Velocity = PlayerVelocity * -1;
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            Velocity = PlayerVelocity;
        }
        else
        {
            Velocity = 0;
        }

        transform.position = transform.position + new Vector3(Velocity, 0, 0) * Time.deltaTime;
    }
}
