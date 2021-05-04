using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanetController : MonoBehaviour
{
    //an array of planets
    public GameObject[] Planets;

    //queue hold the planets
    Queue<GameObject> availablePlanets = new Queue<GameObject>();


    // Start is called before the first frame update
    void Start()
    {
        //add planets to queue (enqueue them)
        availablePlanets.Enqueue(Planets[0]);
        availablePlanets.Enqueue(Planets[1]);
        availablePlanets.Enqueue(Planets[2]);

        //call the moveplanet down function every 20s
        InvokeRepeating("MovePlanetDown", 0, 20f);
    }

    // Update is called once per frame
    void Update()
    {
        EnqueuePlanets();

        if(availablePlanets.Count == 0)
            return;

        GameObject aPlanet = availablePlanets.Dequeue();

        aPlanet.GetComponent<Planet>().isMoving = true;
    }

    //function to enqueue planets that are below the screen and are not moving
    void EnqueuePlanets()
    {
        foreach(GameObject aPlanet in Planets)
        {
            //if the planet is below the screen and the planet is not moving
            if((aPlanet.transform.position.y < 0 ) && (!aPlanet.GetComponent<Planet>().isMoving))
            {

                //reset the planet position
                aPlanet.GetComponent<Planet>().ResetPosition();

                //enqueue the planet
                availablePlanets.Enqueue(aPlanet);
            }
        }
    }
}
