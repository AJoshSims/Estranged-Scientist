using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColumnControllerBehavior : MonoBehaviour
{
    private GameObject larry;

    public ColumnControlEffectBehavior columnBehavior;

    public ColumnControlEffectBehavior buttonBehavior;

    private void Start()
    {
        larry = GameObject.Find("Larry");
    }

    private void Update ()
    {
		if (Input.GetButtonDown("Activate") 
            && ((larry.transform.position - transform.position).magnitude 
            < 5))
        {
            columnBehavior.toggleAscending();
            buttonBehavior.toggleAscending();
        }
	}
}
