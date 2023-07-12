using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Password : MonoBehaviour
{
    [SerializeField] GameObject puzzlePanel;
    [SerializeField] KeyCode interactKey;
    [SerializeField] 
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(interactKey))
        {
            //se activa
        }
    }
    void ActivarPuzzle()
    {
        
    }
}
