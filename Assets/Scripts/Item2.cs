using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Item2 : MonoBehaviour
{
    public Inventory inventory;
    public GameObject armour;
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
        armour.SetActive(false);
        if (inventory.slot1.GetComponent<Button>().GetComponentInChildren<Text>().text == "Empty")
        {
            inventory.slot1.GetComponent<Button>().GetComponentInChildren<Text>().text = "Armour";
        }
        else
        {
            if (inventory.slot2.GetComponent<Button>().GetComponentInChildren<Text>().text == "Empty")
            {
                inventory.slot2.GetComponent<Button>().GetComponentInChildren<Text>().text = "Armour";
            }
            else
            {
                if (inventory.slot3.GetComponent<Button>().GetComponentInChildren<Text>().text == "Empty")
                {
                    inventory.slot3.GetComponent<Button>().GetComponentInChildren<Text>().text = "Armour";
                }
            }
        }

    }
}
