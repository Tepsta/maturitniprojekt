using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Friend : MonoBehaviour
{
    public GameObject dia;
    public Player player;
    public GameObject diatxt;
    bool thing = false;
    bool thing2 = false;
    public Inventory inventory;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Z))
        {
            dia.SetActive(false);
            player.speed = 7.0f;
            player.sprintSpeed = 9.0f;
            if (thing == true)
            {
                thing2 = true;
                inventory.slot0.GetComponent<Button>().GetComponentInChildren<Text>().text = "Sword";
                player.sword.SetActive(false);
            }
        }
        if(thing2 == true)
        {
            diatxt.GetComponent<UnityEngine.UI.Text>().text = "YOU ALREADY HAVE MY SWORD, NOW GO!";
        }
    }
    public void OnTriggerEnter(Collider other)
    {
        thing = true;
        if (player.hasSword == false)
        {
            dia.SetActive(true);
            player.speed = 0.0f;
            player.sprintSpeed = 0.0f;
        }
        else
        {
            dia.SetActive(true);
        }
    }
    public void OnTriggerExit(Collider other)
    {
        thing = false;
    }
}
