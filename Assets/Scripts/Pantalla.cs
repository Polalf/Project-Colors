using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Pantalla : MonoBehaviour
{
    public TextMeshPro numeros;

    public void MostrarNumero(int numero)
    {
        numeros.text += numero.ToString();

        //chequear la cantidad de caracteres
        if(numeros.text.Length == 4)
        {
            // chequear el codigo
        }
    }
}
