using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Code : MonoBehaviour
{
    public TextMeshPro numeros;

    [SerializeField] string respuesta;
    public string currentAns;

    [SerializeField] GameObject puerta; 


    public void MostrarNumero(int numero)
    {
        numeros.text += numero.ToString();
        currentAns += numero;
        //chequear la cantidad de caracteres
        if(numeros.text.Length == 4)
        {
            CheckearNum();
        }
    }


    public void CheckearNum()
    {
        if (currentAns == respuesta)
        {
            puerta.GetComponent<Door>().isOpen = true;
        }
    }
    
    public void LimpiarPantalla()
    {
        numeros.text = "";
        currentAns = "";
    }
}
