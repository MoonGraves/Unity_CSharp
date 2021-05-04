using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Star : MonoBehaviour
{
    //GAME BACKGROUND SCREEN ANIMATIO AS MOVEMENT OR SOMETHING LIKE THAT,
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //get current position of the star
        Vector2 position = transform.position;

        //compute the star's new positions
        position = new Vector2(position.x, position.y + speed * Time.deltaTime);

        //update the star's position
        transform.position = position;

        //bottom-left point of the screen
        Vector2 min = Camera.main.ViewportToWorldPoint ( new Vector2 (0,0));
        //top right point of the screen
        Vector2 max = Camera.main.ViewportToWorldPoint ( new Vector2 (1,1));

        //star goes outside the screen on the bottom & star on top edge of the screen
        //and randomly between the left and right side of the screen
        if(transform.position.y < min.y)
        {
            transform.position = new Vector2(Random.Range(min.x, max.x), max.y);
        }

    }
}
