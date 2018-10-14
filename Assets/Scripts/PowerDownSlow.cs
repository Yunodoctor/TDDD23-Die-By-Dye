using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerDownSlow : MonoBehaviour
{

    private Player player;


    // Use this for initialization
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();
    }

    // Update is called once per fwWrame
    void Update()
    {
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            player.movementSpeed = 3f;
        }
    }
}
