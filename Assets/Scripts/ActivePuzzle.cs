using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(BoxCollider))]
public class ActivePuzzle : MonoBehaviour
{
    [SerializeField] UnityEvent playerClose, playerFar;
    public bool onPz;
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            playerClose.Invoke();
            onPz = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            playerFar.Invoke();
            onPz = false;
        }
    }

}
