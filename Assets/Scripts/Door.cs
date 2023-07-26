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
    [SerializeField] AudioSource fuente;
    [SerializeField] AudioClip openSound, closeSound;
    bool canSound;
    bool canClose;
    // Start is called before the first frame update
    void Start()
    {
        canClose = true;
        canSound = true;
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
            if(canSound)
            {
                fuente.clip = openSound;
                fuente.Play();
                canSound = false;
            }
            
        }
        else
        {
            transform.position = ori.position;
        }
        
        
    }
    public void AbrirPuerta()
    {
        isOpen = true;
    }

    public void CerrarPuerta()
    {
        if(canClose)
        {
            fuente.clip = closeSound;
            fuente.Play();
            isOpen = false;
            canClose = false;
        }

        
    }
}
