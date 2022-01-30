using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    bool thing = false;
    public Player player;
    public GameObject dia;
    public GameObject diatxt;
    public GameObject theDoor;

    void Update()
    {
        if (Input.GetKey(KeyCode.Z))
        {
            dia.SetActive(false);
            player.speed = 7.0f;
            player.sprintSpeed = 9.0f;
        }
        int left = 3 - player.killCount;
        string lefts = left.ToString();
        diatxt.GetComponent<UnityEngine.UI.Text>().text = "TO OPEN THIS DOOR YOU MUST KILL 3 ENEMIES\nENEMIES REMAINING: " + lefts;
    }
    public void OnTriggerEnter(Collider other)
    {
        if (player.killCount < 3)
        {
            dia.SetActive(true);
            player.speed = 0.0f;
            player.sprintSpeed = 0.0f;
        }
        else
        {
            theDoor.SetActive(false);
        }
    }
}
