using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement
{
    public void Move(float horizontalInput, float movementSpeed, Rigidbody2D rb)
    {
        Vector3 movement = new Vector3(horizontalInput, 0);
        rb.velocity = movement * movementSpeed;
    }
}