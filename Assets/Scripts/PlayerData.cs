using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[System.Serializable]
public class PlayerData
{
    public string s0;
    public string s1;
    public string s2;
    public string s3;
    public string s4;
    public string s5;
    public string s6;
    public string s7;
    public int killcount;
    public float[] position;

    public PlayerData (Player player, Inventory inventory)
    {
        s0 = inventory.slot0.GetComponent<Button>().GetComponentInChildren<Text>().text;
        s1 = inventory.slot1.GetComponent<Button>().GetComponentInChildren<Text>().text;
        s2 = inventory.slot2.GetComponent<Button>().GetComponentInChildren<Text>().text;
        s3 = inventory.slot3.GetComponent<Button>().GetComponentInChildren<Text>().text;
        s4 = inventory.slot4.GetComponent<Button>().GetComponentInChildren<Text>().text;
        s5 = inventory.slot5.GetComponent<Button>().GetComponentInChildren<Text>().text;
        s6 = inventory.slot6.GetComponent<Button>().GetComponentInChildren<Text>().text;
        s7 = inventory.slot7.GetComponent<Button>().GetComponentInChildren<Text>().text;
        killcount = player.killCount;
        position = new float[3];
        position[0] = player.transform.position.x;
        position[1] = player.transform.position.y;
        position[2] = player.transform.position.z;
    }
}
