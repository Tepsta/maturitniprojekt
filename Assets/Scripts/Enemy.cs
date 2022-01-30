using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Enemy : MonoBehaviour
{
    public float health = 100.0f;
    public float attack = 1.0f;
    public GameObject npc;
    public GameObject healthBar;
    public Player player;
    bool onetime = true;
    public GameObject dia;
    public GameObject diatxt;
    public GameObject otherdiatxt;
    public Animator eanimator;

    // Start is called before the first frame update
    void Start()
    {
        eanimator.enabled = false;
        healthBar.GetComponent<Slider>().maxValue = health;
    }
    // Update is called once per frame
    void Update()
    {
        if ((player.transform.position - npc.transform.position).sqrMagnitude <= 25 && (player.transform.position - npc.transform.position).sqrMagnitude >= 5)
        {
            AttackPlayer();
        }
        if ((player.transform.position - npc.transform.position).sqrMagnitude <= 25)
        {
            if (onetime == true)
            {
                eanimator.enabled = true;
                Invoke("DoDmg", 1.3f);
                onetime = false;
                Invoke("Cancel", 1.31f);
            }
            if (player.attacking == true)
            {
                ApplyDamage();
            }
        }
            healthBar.GetComponent<Slider>().value = health;
    }

    void ApplyDamage()
    {
        health -= player.attack;
        if (health <= 0)
        {
            if (npc.name == "Enemy")
            {
                player.speed = 0.0f;
                player.sprintSpeed = 0.0f;
                player.armour.SetActive(true);
                diatxt.GetComponent<UnityEngine.UI.Text>().text = "THE ENEMY DROPPED ARMOUR!";
                otherdiatxt.GetComponent<UnityEngine.UI.Text>().text = "*PRESS Z TO CONTINUE*";
                dia.SetActive(true);
                if (Input.GetKey(KeyCode.Z))
                {
                    dia.SetActive(false);
                    player.speed = 7.0f;
                    player.sprintSpeed = 9.0f;
                }
            }
            Destroy(npc);
            player.killCount += 1;
        }
    }
    void AttackPlayer()
    {
        npc.transform.LookAt(-player.transform.position);
        player.armour.transform.LookAt(-player.transform.position);
        float step = 9.0f * Time.deltaTime;
        npc.transform.position = Vector3.MoveTowards(transform.position, player.transform.position, step);
        player.armour.transform.position = Vector3.MoveTowards(transform.position, player.transform.position, step);
    }
    void DoDmg()
    {
        player.health -= attack;
    }
    void Cancel()
    {
        CancelInvoke();
        eanimator.enabled = false;
        onetime = true;
    }
}
