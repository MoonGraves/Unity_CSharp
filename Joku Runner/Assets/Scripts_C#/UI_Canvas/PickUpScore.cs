using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PickUpScore : MonoBehaviour
{
    //KOLIKKON OMINAISUUS 
    public GameObject scoreText;
    public AudioSource collectSound;
    private Vector3 rotation;

    //public int scorePoints; //upottaa tää scecrettoken

    [SerializeField] static int scorePoints = 0;
    [SerializeField] int pickUpScore = 0;

    // Start is called before the first frame update
    void Start()
    {
        rotation = new Vector3(0, 0, 1);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(rotation);
        scoreText.GetComponent<Text>().text = "Coins $: " + scorePoints;

    }

    public void OnTriggerEnter(Collider other)
    {
        collectSound.Play();
        scorePoints += pickUpScore;
        
        Debug.Log("Kerräsit kolikkon");
        //scoreText.GetComponent<Text>().text = "Coins $: " + scorePoints;
        Destroy(gameObject);
    }

}
