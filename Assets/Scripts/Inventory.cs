using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Inventory : MonoBehaviour
{
    public Player player;
    public GameObject slot0;
    public GameObject slot1;
    public GameObject slot2;
    public GameObject slot3;
    public GameObject slot4;
    public GameObject slot5;
    public GameObject slot6;
    public GameObject slot7;
    public GameObject menu;
    public GameObject menubutton;
    // Start is called before the first frame update
    void Start()
    {
        slot0.GetComponent<Button>().GetComponentInChildren<Text>().text = "Empty";
        slot1.GetComponent<Button>().GetComponentInChildren<Text>().text = "Empty";
        slot2.GetComponent<Button>().GetComponentInChildren<Text>().text = "Empty";
        slot3.GetComponent<Button>().GetComponentInChildren<Text>().text = "Empty";
        slot4.GetComponent<Button>().GetComponentInChildren<Text>().text = "Empty";
        slot5.GetComponent<Button>().GetComponentInChildren<Text>().text = "Empty";
        slot6.GetComponent<Button>().GetComponentInChildren<Text>().text = "Empty";
        slot7.GetComponent<Button>().GetComponentInChildren<Text>().text = "Empty";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Clicko(GameObject slot)
    {
        if (slot.GetComponent<Button>().GetComponentInChildren<Text>().text == "Sword")
        {
            if(player.hasSword == true)
            {
                player.psword.SetActive(false);
                player.hasSword = false;
                player.attack = 1.0f;
            }
            else
            {
                player.psword.SetActive(true);
                player.hasSword = true;
            }           
        }
        if (slot.GetComponent<Button>().GetComponentInChildren<Text>().text == "Small Potion")
        {
            slot.GetComponent<Button>().GetComponentInChildren<Text>().text = "Empty";
            player.health += 20;
        }
        if (slot.GetComponent<Button>().GetComponentInChildren<Text>().text == "Armour")
        {
            if (player.hasArmour == true)
            {
                float addon = player.health / player.maxhealth;
                player.parmour.SetActive(false);
                player.health = player.health - addon * 20.0f;
                player.hasArmour = false;
            }
            else
            {
                float addon = player.health / player.maxhealth;
                player.parmour.SetActive(true);
                player.health = player.health + addon * 20.0f;
                player.hasArmour = true;
            }
        }
        if (slot.GetComponent<Button>().GetComponentInChildren<Text>().text == "Treasure")
        {
            //nothing
        }
    }
    public void SavePlayer()
    {
        SaveSystem.SavePlayer(player, this);
    }
    public void LoadPlayer()
    {
        PlayerData data = SaveSystem.LoadPlayer();
        slot0.GetComponent<Button>().GetComponentInChildren<Text>().text = data.s0;
        slot1.GetComponent<Button>().GetComponentInChildren<Text>().text = data.s1;
        slot2.GetComponent<Button>().GetComponentInChildren<Text>().text = data.s2;
        slot3.GetComponent<Button>().GetComponentInChildren<Text>().text = data.s3;
        slot4.GetComponent<Button>().GetComponentInChildren<Text>().text = data.s4;
        slot5.GetComponent<Button>().GetComponentInChildren<Text>().text = data.s5;
        slot6.GetComponent<Button>().GetComponentInChildren<Text>().text = data.s6;
        slot7.GetComponent<Button>().GetComponentInChildren<Text>().text = data.s7;
        player.killCount = data.killcount;
        Vector3 position;
        position.x = data.position[0];
        position.y = data.position[1];
        position.z = data.position[2];
        player.transform.position = position;
    }
    public void Quitogameo()
    {
        SceneManager.LoadScene(0);
    }
    public void OpenmenuButts()
    {
        menubutton.SetActive(false);
        menu.SetActive(true);
    }
    public void ClosemenuButts()
    {
        menubutton.SetActive(true);
        menu.SetActive(false);
    }
}
