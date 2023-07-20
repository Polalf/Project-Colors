using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Password : MonoBehaviour
{
    [SerializeField] string respuesta;
    public string passIng;
    [SerializeField] GameObject door;
    void Start()
    {
        
    }

    
    void Update()
    {
    }

    public void CheckearPass()
    {
        if(passIng == respuesta)
        {
            door.GetComponent<Door>().isOpen =true;
        }
    }
}
