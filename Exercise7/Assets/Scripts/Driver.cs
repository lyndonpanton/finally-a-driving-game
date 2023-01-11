using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Allows a game object to be moved in a scene via keyboard input
/// </summary>
public class Driver : MonoBehaviour
{
    const int MoveUnitsPerSecond = 4;

    // Update is called once per frame
    void Update()
    {
        // movement logic for the horizontal axis
        Vector3 position = transform.position;
        float horizontalInput = Input.GetAxis("Horizontal");

        if (horizontalInput != 0)
        {
            position.x += (horizontalInput * MoveUnitsPerSecond * Time.deltaTime);
        }

        transform.position = position;
    }
}
