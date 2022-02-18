using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class XPSystem : MonoBehaviour
{
    public int Level; //Laps
    public float curXP; //curLapProgress
    public float reqXP; //reqLapProgress

    //stats variables (to be tracked and modified upon Level Up)
    public float health;
    public float defence;
    public float speed;
    public float attack;

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
        //initialize stats, level, xp, reqxp, etc
    }

    public void interaction() //look at button presses in RacingScript
    {
        //interaction caused by button press
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
