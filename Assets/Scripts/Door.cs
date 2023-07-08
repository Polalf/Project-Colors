using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    public bool isOpen = false;
    [SerializeField] float speed;
    [SerializeField] Light doorLight;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(isOpen)
        {
            transform.position += transform.up * speed * Time.deltaTime;
            doorLight.color = new Color(0, 1, 0, 1);
        }
        if(transform.position.y >= 7)
        {
            speed = 0;
        }
    }
}
