using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PassChar : MonoBehaviour
{
    public int indiceCasilla;
    [SerializeField] Password pantalla;
    [SerializeField] GameObject[] caracteres;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        caracteres[indiceCasilla].SetActive(true);

    }

    public void Arriba()
    { 
        indiceCasilla++;
        if(indiceCasilla >= caracteres.Length)
        {
            indiceCasilla = caracteres.Length -1;
        }
        for(int x = 0; x < caracteres.Length; x++)
        {
            caracteres[x].SetActive(false);
        }
        
    }

    public void Abajo()
    {
        indiceCasilla--;
        if(indiceCasilla <0)
        {
            indiceCasilla = 0;
        }
        for (int x = 0; x < caracteres.Length; x++)
        {
            caracteres[x].SetActive(false);
        }
    }
}
