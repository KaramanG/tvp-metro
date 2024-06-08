using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RespawnScript : MonoBehaviour
{
    [SerializeField] private Transform root;
    [SerializeField] private GameObject player;

    private void Start()
    {
        respawnPlayer();
    }

    private void Update()
    {
        if (Input.GetKeyUp(KeyCode.Escape))
        {
            respawnPlayer();
        }
    }

    private void respawnPlayer()
    {
        player.transform.position = root.position;
    }
}
