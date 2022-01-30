using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public float gravity = 20.0f;
    public float speed = 9.0f;
    public float sprintSpeed = 11.0f;
    public float maxhealth = 100.0f;
    public float health = 100.0f;
    public float attack = 1.0f;
    public bool attacking = false;
    public bool hasSword = false;
    public bool hasArmour = false;
    public bool hasTreasure = false;
    public GameObject psword;
    public GameObject sword;
    public GameObject parmour;
    public GameObject armour;
    public GameObject healthBar;
    public int killCount = 0;
    public Animator sanimator;
    public GameObject animes;
    bool animationthing = true;
    public GameObject player;
    public GameObject dia;
    public GameObject diatxt;
    public GameObject otherdiatxt;


    private Vector3 moveDirection = Vector3.zero;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        healthBar.GetComponent<Slider>().maxValue = maxhealth;
        if (health > maxhealth)
        {
            //health = maxhealth;
        }
        var horizontal = Input.GetAxis("Horizontal");
        var vertical = Input.GetAxis("Vertical");
        if (Input.GetKey(KeyCode.LeftShift))
        {
            transform.Translate(new Vector3(horizontal, 0, vertical) * (sprintSpeed * Time.deltaTime));
        }
        else
        {
            transform.Translate(new Vector3(horizontal, 0, vertical) * (speed * Time.deltaTime));
        }
        moveDirection.y -= gravity * Time.deltaTime;
        if (Input.GetButtonDown("Fire1"))
        {
            Attack();
            if (hasSword == true && animationthing == true)
            {
                sanimator.enabled = true;
                animationthing = false;
                Invoke("DisableAnime", 1.01f);
            }
        }
        else
        {
            attacking = false;
        }
        if(hasSword == true)
        {
            attack = 5.0f;
        }
        if (hasArmour == true)
        {
            maxhealth = 120.0f;
            armour.SetActive(false);
        }
        if (hasSword == false)
        {
            attack = 1.0f;
        }
        if (hasArmour == false)
        {
            maxhealth = 100.0f;
        }
        healthBar.GetComponent<Slider>().value = health;
        if(health <= 0)
        {
            diatxt.GetComponent<UnityEngine.UI.Text>().text = "YOU LOSE!";
            otherdiatxt.GetComponent<UnityEngine.UI.Text>().text = "*RETURNING TO MAIN MENU IN 5 SECONDS*";
            dia.SetActive(true);
            Invoke("RToMenu", 5);
        }
    }
    void RToMenu()
    {
        SceneManager.LoadScene(0);
    }
    void Attack()
    {
        attacking = true;
    }
    void DisableAnime()
    {
        sanimator.enabled = false;
        animationthing = true;
    }
}
