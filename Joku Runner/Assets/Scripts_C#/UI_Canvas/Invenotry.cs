using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Invenotry : MonoBehaviour
{
    public GameObject inventory;
    public GameObject slotHolder;

    private bool inventoryEnabled;

    private int slots;
    private Transform[] slot;
    
    private GameObject itemPickedUp;

    private bool itemAdded;

    //
    private List<Item> itemList;

    public void Inventory()
    {
        itemList = new List<Item>();
        Debug.Log("Inventory");
    }


    // Start is called before the first frame update
    public void Start()
    {
        //slots being detected
        slots = slotHolder.transform.childCount;
        slot = new Transform[slots];
        DetectInvenotrySlots();
    }

    // Update is called once per frame
    public void Update()
    {
        //inventoryEnabled.GetComponent<Guide>().GuideEnabled;
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            inventoryEnabled = !inventoryEnabled;
        }

        if(inventoryEnabled)
            inventory.SetActive(true);
        else
            inventory.SetActive(false);
        
    }

    public void OnTriggerEnter(Collider other) 
    {
        if(other.tag == "Item")
        {
            Debug.Log("Colliding"); //print("Colliding!"); //toimii print & Debug.Log("")
            itemPickedUp = other.gameObject;
            AddItem(itemPickedUp);
        }
    }

    public void OnTriggerExit(Collider other) 
    {
        if (other.tag == "Item")
        {
            itemAdded = false;
        }
    }

    public void AddItem(GameObject item)
    {
        for(int i = 0; i < slots; i++ )
        {
            if(slot[i].GetComponent<Slot>().empty && itemAdded == false)
            {                
                slot[i].GetComponent<Slot>().item = itemPickedUp;
                slot[i].GetComponent<Slot>().itemIcon = itemPickedUp.GetComponent<Item>().icon;
                itemAdded = true;
            }
        }
    }

    public void DetectInvenotrySlots()
    {
        for (int i = 0; i < slots; i++ )
        {
            slot[i] = slotHolder.transform.GetChild(i);
            //print(slot[i].name);
        }
    }
}
