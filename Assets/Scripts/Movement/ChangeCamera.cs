using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ChangeCamera : MonoBehaviour
{
    public Camera playerCam;

    public UnityEvent main, filtro1, filtro2;
   
    

    
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Alpha1))
        {
            filtro1.Invoke();
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            filtro2.Invoke();
        }
        if(Input.GetKeyDown(KeyCode.Space))
        {
            main.Invoke();
        }
    }

   
}
