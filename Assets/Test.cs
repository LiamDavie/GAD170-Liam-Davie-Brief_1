using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    //variables up top
    /*
     multi line comment
     */
    public int fuel = 100;
    public int laps;
    public float LapProgress;
    public float reqLapProgress = 200f;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //check how much fuels we have
        //if we still have more than zero fuel, we move

        if (fuel > 0)
        {
            //we have fuel
            //increase our current prgress and decrease our fuel
            LapProgress+= 5; //increase by 5
            fuel--; //decrease by 1
        }
        else
        {
            //we don't have fuel
            Debug.Log("We've run out of fuel!");
        }
        
        //is our current progress equal to or higher than the required progress
        if(LapProgress >= reqLapProgress)
        {
            //if it is, increase our lap count and reset our current progress
            laps++; //increase laps by 1
            LapProgress = 0; //reset lap progress
        }
        Debug.Log("Current Fuel: " + fuel);
        Debug.Log("Completed Laps: " + laps);
           
    }
}
