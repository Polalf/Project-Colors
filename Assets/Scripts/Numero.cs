using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Numero : MonoBehaviour
{
    public Code pantalla;
    public int valor;
    private void OnMouseDown()
    {
        pantalla.MostrarNumero(valor);
    }
}
