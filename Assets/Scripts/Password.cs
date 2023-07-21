using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Password : MonoBehaviour
{
    [SerializeField] int[] respuesta;
    public PassChar[] passIng;
    [SerializeField] Door door;
    void Start()
    {
        
    }

    
    void Update()
    {
        CheckearPass();
    }

    public void CheckearPass()
    {
        int aciertos = 0;
        for(int x = 0; x<respuesta.Length; x++)
        {
            if(passIng[x].indiceCasilla == respuesta[x])
            {
                aciertos++;
            }
        }

        if(aciertos == respuesta.Length)
        {
            door.isOpen = true;
        }
        
    }
}
