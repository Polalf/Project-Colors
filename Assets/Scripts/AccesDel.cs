using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class AccesDel : MonoBehaviour
{

    public UnityEvent onclick;

   
    private void OnMouseDown()
    {
        onclick.Invoke();
    }
}
