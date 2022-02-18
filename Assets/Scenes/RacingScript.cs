using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RacingScript : MonoBehaviour
{
    // Start is called before the first frame update

    int Lap = 0;
    float curLapProgress = 0.0f;
    float reqLapProgress = 100.0f;

    float Speed = 10.0f;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            gainprogress(Speed);
        }

 
    }

    public void gainprogress(float progress)
    {
        curLapProgress += progress;
            Debug.Log("Gained " + progress + "progress");
        Debug.Log("Total current progress is now: " + curLapProgress);
        CheckProgress(curLapProgress);

    }

    public void CheckProgress(float progress)
    {
        if (progress >= reqLapProgress)
        {
            //Completed Lap!
            LapCompleted();

            Debug.Log("Reached the required progress!");
        }
    }

    public void LapCompleted()
    {
        //update laps
        Lap++;
        //update curprogress
        curLapProgress = 0f;
        //update reqprogress
        reqLapProgress *= 1.15f;
        //update speed
        Speed++;
        Debug.Log("Completed" + Lap + "Laps");
    }
}
