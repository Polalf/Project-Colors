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
        else
        {
            StartCoroutine(IncorrectAnim());
        }
    }
    
    public void LimpiarPantalla()
    {
        numeros.text = "";
        currentAns = "";
    }

    IEnumerator IncorrectAnim()
    {
        int x = 0;
        while(x < 3)
        {
            numeros.color = new Color(1, 0, 0);
            yield return new WaitForSeconds(.2f);
            numeros.color = new Color(1, 1, 1);
            yield return new WaitForSeconds(.2f);
            x++;
        }
        numeros.text = "";
        currentAns = "";
    }
}
