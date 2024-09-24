using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInvoker
{
    private PlayerMovement playerMovement;
    private Player player;

    public PlayerInvoker(Player player)
    {
        playerMovement = new PlayerMovement();
        this.player = player;
    }

    public void InvokeMove(float horizontalInput)
    {
        playerMovement.Move(horizontalInput, player.movementSpeed, player.Rb);
    }
}
