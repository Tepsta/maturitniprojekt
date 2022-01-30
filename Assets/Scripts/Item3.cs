using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Item3 : MonoBehaviour
{
    public Inventory inventory;
    public GameObject treasure;
    public Player player;
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
        player.hasTreasure = true;
        treasure.SetActive(false);
        if (inventory.slot1.GetComponent<Button>().GetComponentInChildren<Text>().text == "Empty")
        {
            inventory.slot1.GetComponent<Button>().GetComponentInChildren<Text>().text = "Treasure";
        }
        else
        {
            if (inventory.slot2.GetComponent<Button>().GetComponentInChildren<Text>().text == "Empty")
            {
                inventory.slot2.GetComponent<Button>().GetComponentInChildren<Text>().text = "Treasure";
            }
            else
            {
                if(inventory.slot3.GetComponent<Button>().GetComponentInChildren<Text>().text == "Empty")
                {
                    inventory.slot3.GetComponent<Button>().GetComponentInChildren<Text>().text = "Treasure";
                }
            }
        }

    }
}
