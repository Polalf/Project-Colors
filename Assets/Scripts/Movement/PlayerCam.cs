using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCam : MonoBehaviour
{
    [Header("Camera")]
    [SerializeField] float sens;

    [SerializeField] Transform orientation;

    float xRota = 0f;
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }


    void Update()
    { 
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
            float mouseX = Input.GetAxisRaw("Mouse X") * Time.deltaTime * sens;
            float mouseY = Input.GetAxisRaw("Mouse Y") * Time.deltaTime * sens;


            xRota -= mouseY;
            xRota = Mathf.Clamp(xRota, -90f, 90f);

            transform.localRotation = Quaternion.Euler(xRota, 0, 0);
            orientation.Rotate(Vector3.up * mouseX);
       
        
    }
}
