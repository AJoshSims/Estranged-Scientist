using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColumnBehavior : MonoBehaviour
{
    private bool ascending;

    private static float speed = 10;

    private float columnPositionX;

    private float originalColumnPositionY;

    public float maxColumnPositionY;

    private float columnPositionZ;

    internal void toggleAscending()
    {
        ascending = !ascending;
    }

    private void Awake()
    {
        ascending = false;
    }

    private void Start ()
    {
        columnPositionX = transform.position.x;
        originalColumnPositionY = transform.position.y;
        columnPositionZ = transform.position.z;
	}
	
	private void Update ()
    {
        if (
            ascending == true && transform.position.y 
            < maxColumnPositionY)
        {
            transform.position = Vector3.MoveTowards(
                transform.position,
                new Vector3(
                columnPositionX,
                maxColumnPositionY,
                columnPositionZ),
                speed * Time.deltaTime);
        }

        else if (
            ascending == false && transform.position.y 
            > originalColumnPositionY)
        {
            transform.position = Vector3.MoveTowards(
                transform.position,
                new Vector3(
                columnPositionX,
                originalColumnPositionY,
                columnPositionZ),
                speed * Time.deltaTime);
        }
	}
}
