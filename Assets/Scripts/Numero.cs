using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Numero : MonoBehaviour
{
    public Pantalla pantalla;
    public int valor;
    private void OnMouseDown()
    {
        pantalla.MostrarNumero(valor);
    }
}
