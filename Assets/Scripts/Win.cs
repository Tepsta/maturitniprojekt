using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Win : MonoBehaviour
{
    public Player player;
    public GameObject dia;
    public GameObject diatxt;
    public GameObject otherdiatxt;

    void Update()
    {
        if (player.killCount < 4)
        {
            if (Input.GetKey(KeyCode.Z))
            {
                dia.SetActive(false);
                player.speed = 7.0f;
                player.sprintSpeed = 9.0f;
            }
        }
    } 
    public void OnTriggerEnter(Collider other)
    {
        dia.SetActive(true);
        player.speed = 0.0f;
        player.sprintSpeed = 0.0f;
        if (player.killCount >= 4)
        {
            diatxt.GetComponent<UnityEngine.UI.Text>().text = "YOU WIN!";
            otherdiatxt.GetComponent<UnityEngine.UI.Text>().text = "*RETURNING TO MAIN MENU IN 5 SECONDS*";
            Invoke("RToMenu", 5);
        }
    }
    void RToMenu()
    {
        SceneManager.LoadScene(0);
    }
}
