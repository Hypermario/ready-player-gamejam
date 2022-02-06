using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LostWoodTrigger : MonoBehaviour
{
    public Transform spawnPoint;
    private PlayerController1 player;

    private void Start()
    {
        player = GameObject.FindObjectOfType<PlayerController1>();
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Player"))
        {
            player.Tp(spawnPoint);
        }
    }
}
