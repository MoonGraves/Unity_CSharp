using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Planet : MonoBehaviour
{
    //Typerät planeettat background:issa

    public float speed;
    public bool isMoving;

    Vector2 min;    //bottom-left point of the screen

    Vector2 max;    //top right point of the screen

    void Awake() 
    {
        isMoving = false;

        min = Camera.main.ViewportToWorldPoint ( new Vector2 (0,0));
        max = Camera.main.ViewportToWorldPoint ( new Vector2 (1,1));

        //add planets spirte half height to max y
        max.y = max.y + GetComponent<SpriteRenderer>().sprite.bounds.extents.y;

        //subtract the planet sprite half height to min y
        min.y = min.y + GetComponent<SpriteRenderer>().sprite.bounds.extents.y;
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(!isMoving)
            return;

        //get current position of the planet
        Vector2 position = transform.position;

        //compute the planets new position
        position = new Vector2 (position.x, position.y + speed * Time.deltaTime);

        //update the planets positions
        transform.position = position;

        //if the planets get to the minimun y position then stop moving the planets
        if(transform.position.y < min.y)
        {
            isMoving = false;
        }
    }

    public void ResetPosition()
    {
        transform.position = new Vector2 (Random.Range(min.x, max.x), max.y);
    }
}
