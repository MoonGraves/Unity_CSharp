using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CutSceneEnter : MonoBehaviour
{
    public GameObject thePlayer;
    public GameObject cutSceneCam;

    public TextMeshProUGUI textDisplay;
 

    //TÄÄ ON TOI KUUTIO MIKÄ ON KENTÄLLÄ & CutSceneCube
    void OnTriggerEnter(Collider other) 
    {
        this.gameObject.GetComponent<BoxCollider>().enabled = false; //
        cutSceneCam.SetActive(true);
        thePlayer.SetActive(false);
        StartCoroutine(FinishCut()); //
    }

    IEnumerator FinishCut()
    {
        //palautaa alkuperäisen muotoon n. 10s jälkeen, esim. pyörittää yli 30s cutscene videon, 
        //niin antaa luvan pyörittää n. 10s, lopput 20s ei jatku enään
        //cutscene toistuu vain kerran
        yield return new WaitForSeconds(10);
        thePlayer.SetActive(true);
        cutSceneCam.SetActive(false);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
