using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarGenerator : MonoBehaviour
{

    public GameObject Star; //tähän tulee prefabs kansiosta --> Star objekti
    public int MaxStars;

    //värin asettaminen menee rgb mukaan
    Color[] starColors = 
    {
        new Color(0.5f, 0.5f, 1f),
        new Color(0f, 1f, 1f),
        new Color(1f, 1f, 0),
        new Color(1f, 0, 0),
    };

    // Start is called before the first frame update
    void Start()
    {
        //bottom-left point of the screen
        Vector2 min = Camera.main.ViewportToWorldPoint ( new Vector2 (0,0));
        //top right point of the screen
        Vector2 max = Camera.main.ViewportToWorldPoint ( new Vector2 (1,1));

        //loop to create stars
        for(int i = 0; i < MaxStars; ++i)
        {
            GameObject star = (GameObject)Instantiate(Star);

            //set the star color
            star.GetComponent<SpriteRenderer>().color = starColors[i % starColors.Length];

            //set the position of the star random x and random y
            star.transform.position = new Vector2(Random.Range(min.x, max.x), Random.Range(min.y, max.y));

            //set random speed for the star
            star.GetComponent<Star>().speed = -(1f * Random.value + 0.5f);

            //make the star a schild of the stargeneratorgo
            star.transform.parent = transform;

        }

    }

    // Update is called once per frame
    void Update()
    {
        

    }
}
