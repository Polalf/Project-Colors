using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeRoomColor : MonoBehaviour
{
    [SerializeField] Light roomLight;
    [SerializeField] GameObject[] roomParts, secrets; 
    [SerializeField] int colorRoom;
    void Start()
    {
        CambioDeColor(colorRoom);
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void OnMouseDown()
    {
        colorRoom++;
        if (colorRoom > 3) colorRoom = 0;
        CambioDeColor(colorRoom);

    }

    void CambioDeColor(int color)
    {
        if(color == 0) //BLANCO
        {
            roomLight.color = new Color(1,1,1);
            for(int x = 0;x < roomParts.Length;x++)
            {
                roomParts[x].GetComponent<Material>().color = new Color(1, 1, 1);
            }
        }
        else if(color == 1) //ROJO
        {
            roomLight.color = new Color(1, 0, 0);
            for (int x = 0; x < roomParts.Length; x++)
            {
                roomParts[x].GetComponent<Material>().color = new Color(1, 0, 0);
            }
        }
        else if (color == 2) //VERDE
        {
            roomLight.color = new Color(0, 1, 0);
            for (int x = 0; x < roomParts.Length; x++)
            {
                roomParts[x].GetComponent<Material>().color = new Color(0, 1, 0);
            }
        }
        else if (color == 3) //AZUL
        {
            roomLight.color = new Color(0, 0, 1);
            for (int x = 0; x < roomParts.Length; x++)
            {
                roomParts[x].GetComponent<Material>().color = new Color(0, 0, 1);
            }
        }
    }
}
