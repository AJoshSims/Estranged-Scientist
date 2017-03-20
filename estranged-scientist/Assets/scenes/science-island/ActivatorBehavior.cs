using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivatorBehavior : MonoBehaviour
{
    public GameObject larry;

    public Shiftable shiftableColumn;

    public Shiftable shiftableButton;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == larry 
            && Input.GetButtonDown("Activate"))
        {
            shiftableColumn.toggleShifting();
            shiftableButton.toggleShifting();
        }
    }
}
