using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class XPSystem : MonoBehaviour
{
    public int level;      //Laps
    public float curXP;      //curLapProgress
    public float reqXP;     //reqLapProgress

    //stats variables (to be tracked and modified upon Level Up)
    public float health;
    public float defence;
    public float speed;
    public float attack;
    public float EnemyHealth;

    // Start is called before the first frame update
    void Start()
    {
        health = 100;
        EnemyHealth = 30;
        attack = 10;
        defence = 20;
        speed = 10;
        Debug.Log("Welcome! Use left arrow key to attack and right arrow key to defend, to fight and level up. Current health is: " + health);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            EnemyHealth -= attack;
            health -= 10;
            Debug.Log("Attack for " + attack + ", health at " + health);
            initialstats();

        }
        //interaction caused by button press
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            health += 5;
            Debug.Log("Defended, health at " + health);
            initialstats();
        }
    }
    public void initialstats()
    {
        if (health > 0)
        {
            level = level;
            curXP = curXP;
            reqXP = 100;
            defence = defence;
            speed = speed;
            attack = attack;
            interaction();
        }
        else
        {
            level = 0;
            curXP = 0;
            reqXP = 100;
            defence = 0;
            speed = 0;
            attack = 0;
            Debug.Log("You have fallen!");
        }
        //initialize stats, level, xp, reqxp, etc
    }

    public void interaction() //look at button presses in RacingScript
    {
        
        Debug.Log("Enemy health is now: " + EnemyHealth);
        if (EnemyHealth <= 0)
            GainXP();
      


    }

    public void GainXP() //gain progress
    {
            //Enemy defeated
            curXP += 20;
        EnemyHealth = 30;
        Debug.Log("Enemy Defeated! Respawning enemy.");
        //increase our current XP
        LevelUP();
    }

    public void LevelUP() //gain lap
    {
        //increase our level
        if (curXP >= reqXP)
        {
            level++;
            curXP = 0;
            Debug.Log("Level Up! You are now Level " + level);
            IncreaseStats();
        }
        if (curXP < reqXP)
        {
            Debug.Log("Current XP:" + curXP);
        }
    }

    public void IncreaseStats()
    {
        attack ++;
        defence ++;
        speed ++;
        //Improve our stats
        Debug.Log("Stats increased! Attack now: " + attack + "! Defence now: " + defence + "! Speed now" + speed + "!");
    }

}
