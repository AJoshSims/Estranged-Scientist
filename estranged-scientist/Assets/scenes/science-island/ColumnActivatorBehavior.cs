using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class ColumnActivatorBehavior : MonoBehaviour
{
    public Shift column;

    public Shift button;

    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<FirstPersonController>() != null 
            && Input.GetButtonDown("Activate"))
        {
            column.toggleShifting();
            button.toggleShifting();
        }
    }
}
