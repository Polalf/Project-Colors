using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Lantern : MonoBehaviour
{
    public Image red, green,blue;
    [SerializeField] Light linterna;
    bool lanternOn;
    // Start is called before the first frame update
    void Start()
    {
       lanternOn = false;
    }

    // Update is called once per frame
    void Update()
    {
        linterna.enabled =lanternOn;
        if (Input.GetKeyDown(KeyCode.F))
        {
            lanternOn = !lanternOn;
            
        }
        if(Input.GetKeyDown(KeyCode.Alpha1))
        {
            red.color = new Color(1,0,0,1);
            green.color = new Color(0, 1, 0, 0.5f);
            blue.color = new Color(0, 0, 1, 0.5f);
            linterna.color = new Color(1, 0, 0, 1);
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            red.color = new Color(1, 0, 0, 0.5f);
            green.color = new Color(0, 1, 0, 1);
            blue.color = new Color(0, 0, 1, 0.5f);
            linterna.color = new Color(0, 1, 0, 1);
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            red.color = new Color(1, 0, 0, 0.5f);
            green.color = new Color(0, 1, 0, 0.5f);
            blue.color = new Color(0, 0, 1, 1);
            linterna.color = new Color(0, 0, 1, 1);
        }
    }

    
}
