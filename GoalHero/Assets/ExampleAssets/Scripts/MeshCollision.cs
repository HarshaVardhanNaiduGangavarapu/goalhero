using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class MeshCollision : MonoBehaviour
{
    bool timeKeeper = false;
    

    // Start is called before the first frame update
    void OnCollisionEnter (Collision collision)
    {
        if(timeKeeper == false)
        {
            ScoreScript.scoreValue += 1;
            Handheld.Vibrate();

            AudioManager.PlaySound();
            timeKeeper = true;
            Thread thread = new Thread(resetTimeKeeper);
            thread.Start();
        } 

    }

    void resetTimeKeeper()
    {
        DateTime dt = DateTime.Now;
        while (DateTime.Now < dt.AddSeconds(5)) { }
        timeKeeper = false;
    }
}
