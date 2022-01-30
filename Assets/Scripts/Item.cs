using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Item : MonoBehaviour
{
    public Inventory inventory;
    public GameObject smallPotion;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnTriggerEnter(Collider other)
    {
        smallPotion.SetActive(false);
        if(inventory.slot1.GetComponent<Button>().GetComponentInChildren<Text>().text == "Empty")
        {
            inventory.slot1.GetComponent<Button>().GetComponentInChildren<Text>().text = "Small Potion";
        }
        else
        {
            if (inventory.slot2.GetComponent<Button>().GetComponentInChildren<Text>().text == "Empty")
            {
                inventory.slot2.GetComponent<Button>().GetComponentInChildren<Text>().text = "Small Potion";
            }
            else
            {
                if (inventory.slot3.GetComponent<Button>().GetComponentInChildren<Text>().text == "Empty")
                {
                    inventory.slot3.GetComponent<Button>().GetComponentInChildren<Text>().text = "Small Potion";
                }
            }
        }

    }
}
