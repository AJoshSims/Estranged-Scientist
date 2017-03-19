using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColumnControlEffectBehavior : MonoBehaviour
{
    private bool ascending;

    public float speed;

    private float positionX;

    private float originalPositionY;

    public float maxPositionY;

    private float positionZ ;

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
        positionX = transform.localPosition.x;
        originalPositionY = transform.localPosition.y;
        positionZ = transform.localPosition.z;
	}
	
	private void Update ()
    {
        if (
            ascending == true && transform.localPosition.y 
            < maxPositionY)
        {
            transform.localPosition = Vector3.MoveTowards(
                transform.localPosition,
                new Vector3(
                positionX,
                maxPositionY,
                positionZ),
                speed * Time.deltaTime);
        }

        else if (
            ascending == false && transform.localPosition.y 
            > originalPositionY)
        {
            transform.localPosition = Vector3.MoveTowards(
                transform.localPosition,
                new Vector3(
                positionX,
                originalPositionY,
                positionZ),
                speed * Time.deltaTime);
        }
	}
}
