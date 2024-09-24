using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputListener : MonoBehaviour
{
    [SerializeField] private Player player;
    private PlayerInvoker playerInvoker;

    private void Awake()
    {
        playerInvoker = new PlayerInvoker(player);
    }

    void Update()
    {
        ReadMovement();
    }

    private void ReadMovement()
    {
        float horizontalInput = Input.GetAxis("Horizontal");

        if (horizontalInput != 0 )
        {
            playerInvoker.InvokeMove(horizontalInput);
        }
    }
}

