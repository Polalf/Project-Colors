using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeControl : MonoBehaviour
{
    bool stop;
    void Start()
    {
        stop = false;
        Time.timeScale =1;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            stop  = !stop;
        }
        if(stop) Time.timeScale = 0;
        else Time.timeScale = 1;
    }
}
