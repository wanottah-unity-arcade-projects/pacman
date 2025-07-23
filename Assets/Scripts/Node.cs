
using System.Collections.Generic;
using UnityEngine;


public class Node : MonoBehaviour
{
    public LayerMask obstacleLayer;

    // list of available directions
    public readonly List<Vector2> availableDirections = new();



    private void Start()
    {
        availableDirections.Clear();

        // determine what direction is available by box casting to see if a wall is hit
        // the direction is added to the available list
        CheckAvailableDirection(Vector2.up);

        CheckAvailableDirection(Vector2.down);

        CheckAvailableDirection(Vector2.left);

        CheckAvailableDirection(Vector2.right);
    }


    private void CheckAvailableDirection(Vector2 direction)
    {
        RaycastHit2D hit = Physics2D.BoxCast(transform.position, Vector2.one * 0.5f, 0f, direction, 1f, obstacleLayer);

        // if no collider is hit
        if (hit.collider == null)
        {
            // there is no obstacle in that direction
            availableDirections.Add(direction);
        }
    }


} // end of class