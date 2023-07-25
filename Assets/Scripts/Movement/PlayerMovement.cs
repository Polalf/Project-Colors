using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [Header("Movement")]
    [SerializeField] float speed;
    float currentSpeed;
    [SerializeField] AudioClip[] steps;
    [SerializeField] AudioSource fuente;
    
    bool canSound;
    public CharacterController controller;

   

    void Start()
    {
        canSound = true;
        currentSpeed = speed;
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * z;

        controller.Move(move * currentSpeed * Time.deltaTime);
        if(canSound)
        {
            if (z != 0 || x != 0)
            {
                StartCoroutine(SonidoPaso());
            }
        }
    }
    IEnumerator SonidoPaso()
    {
        canSound = false;
        int numStep;
        numStep = Random.Range(0, steps.Length);
        fuente.clip = steps[numStep];
        fuente.Play();
        yield return new WaitForSeconds(0.65f);
        canSound = true;
    }
}
