using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class BotonInGame : MonoBehaviour
{

    public UnityEvent onclick;
    [SerializeField] AudioSource fuente;
   
    private void OnMouseDown()
    {
        onclick.Invoke();
        fuente.Play();
    }
}
