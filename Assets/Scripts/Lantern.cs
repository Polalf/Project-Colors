using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Lantern : MonoBehaviour
{
    public Image red, green,blue,luz;
    [SerializeField] Light linterna;
    [SerializeField] LayerMask[] filtros;
    [SerializeField] Camera playerCam;
    bool lanternOn;
    [SerializeField] AudioSource fuente;
    // Start is called before the first frame update
    void Start()
    {
        lanternOn = false;
        CambiarColorLinterna(0);
    }

    // Update is called once per frame
    void Update()
    {
        linterna.enabled =lanternOn;
        luz.enabled = lanternOn;
        if (Input.GetKeyDown(KeyCode.F))
        {
            lanternOn = !lanternOn;
            fuente.Play();

        }
        if (Input.GetKeyDown(KeyCode.Alpha1)) CambiarColorLinterna(0);
        if (Input.GetKeyDown(KeyCode.Alpha2)) CambiarColorLinterna(1);
        if (Input.GetKeyDown(KeyCode.Alpha3)) CambiarColorLinterna(2);
    }
    void CambiarColorLinterna(int color)
    {
        if (color == 0)
        {
            red.color = new Color(1, 0, 0, 1);
            green.color = new Color(0, 1, 0, 0.5f);
            blue.color = new Color(0, 0, 1, 0.5f);
            linterna.color = new Color(1, 0, 0, 1);
            linterna.cullingMask = filtros[0];
            playerCam.cullingMask = filtros[0];


        }
        if (color == 1)
        {
            red.color = new Color(1, 0, 0, 0.5f);
            green.color = new Color(0, 1, 0, 1);
            blue.color = new Color(0, 0, 1, 0.5f);
            linterna.color = new Color(0, 1, 0, 1);
            linterna.cullingMask = filtros[1];
            playerCam.cullingMask = filtros[1];
        }
        if (color == 2)
        {
            red.color = new Color(1, 0, 0, 0.5f);
            green.color = new Color(0, 1, 0, 0.5f);
            blue.color = new Color(0, 0, 1, 1);
            linterna.color = new Color(0, 0, 1, 1);
            linterna.cullingMask = filtros[2];
            playerCam.cullingMask = filtros[2];
        }
    }
}
