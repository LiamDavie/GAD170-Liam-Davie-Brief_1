using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class XPSystem : MonoBehaviour
{
    public int Level = 1;      //Laps
    public float curXP = 0;      //curLapProgress
    public float reqXP = 100;     //reqLapProgress

    //stats variables (to be tracked and modified upon Level Up)
    public float health = 100;
    public float defence = 50;
    public float speed = 10;
    public float attack = 10;
    public float EnemyHealth = 30;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
    }
    public void initialstats()
    {
        if (health > 0)
        {
            Level = level;
            curXP = curXP;
            defence = defence;
            speed = speed;
            attack = attack;
        }
        else
        {
            Level = 0;
            curXP = 0;
            defence = 0;
            speed = 0;
            attack = 0;
            Debug.Log("You have fallen!");
        }
        //initialize stats, level, xp, reqxp, etc
    }

    public void interaction() //look at button presses in RacingScript
    {
        if(Input.GetKeyDown(KeyCode.LeftArrow))
        {
            EnemyHealth -= attack;
            health -= 10;
            Debug.Log("Attack for " + attack + ", health at " + health);

        }
        //interaction caused by button press
        if(Input.GetKeyDown(KeyCode.RightArrow))
        {
            health += 5;
            Debug.Log("Defended, health at " + health);
        }

        if (EnemyHealth = 0)
            //Enemy defeated
            curXP + 20;
        EnemyHealth = 30;

    }

    public void GainXP() //gain progress
    {
        

        //increase our current XP
    }

    public void LevelUP() //gain lap
    {
        //increase our level
    }

    public void IncreaseStats()
    {
        //Improve our stats
    }
}
