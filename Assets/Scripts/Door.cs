using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    public bool isOpen = false;
    [SerializeField] float speed;
    float currentSpeed;
    [SerializeField] Transform ori;
    [SerializeField] SpriteRenderer doorLight;
    
    // Start is called before the first frame update
    void Start()
    {
        currentSpeed = speed;
    }

    // Update is called once per frame
    void Update()
    {
        if(isOpen)
        {
            transform.position += transform.up * currentSpeed * Time.deltaTime;
            doorLight.color = new Color(0, 1, 0, 1);
            if (transform.position.y >= 7)
            {
                currentSpeed = 0;
            }
        }
        else
        {
            transform.position = ori.position;
        }
        
        
    }

    public void CerrarPuerta()
    {
        isOpen = false;
    }
}
