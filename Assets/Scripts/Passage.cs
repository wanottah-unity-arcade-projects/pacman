
using UnityEngine;


[RequireComponent(typeof(Collider2D))]
public class Passage : MonoBehaviour
{
    /* 
       passage controller
    
       controls what happens when pacman or the ghosts
       leave the left or right side of the passages
    */


    // reference to the passage connectors - ( left / right sides )
    public Transform connection;



    // when pacman or the ghost's collide with the passage exits - ( left / right sides )
    private void OnTriggerEnter2D(Collider2D collidingObject)
    {
        // get pacman's / ghost's current position in the passage - ( left / right sides )
        Vector3 position = collidingObject.transform.position;

        // set the new position for pacman / ghost's on the opposite side of the passage - ( left / right sides )
        position.x = connection.position.x;

        position.y = connection.position.y;

        // move pacman / ghosts to the opposite side of the passage - ( left / right sides )
        collidingObject.transform.position = position;
    }


} // end of class
