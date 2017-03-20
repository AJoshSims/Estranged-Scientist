using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shiftable : MonoBehaviour
{
    private bool shifting;

    public float speed;

    private Vector3 initialPosition;

    public float maxShiftedLocalPositionX;

    public float maxShiftedLocalPositionY;

    public float maxShiftedLocalPositionZ;

    private Vector3 maxShiftedLocalPosition;

    private void Awake()
    {
        initialPosition = transform.position;

        maxShiftedLocalPosition = new Vector3(
            maxShiftedLocalPositionX,
            maxShiftedLocalPositionY,
            maxShiftedLocalPositionZ);
    }

    internal void toggleShifting()
    {
        shifting = !shifting;
    }

    protected void Shift()
    {
        if (shifting == true)
        {
            transform.localPosition = Vector3.MoveTowards(
                transform.localPosition,
                maxShiftedLocalPosition,
                speed * Time.deltaTime);
        }

        else if (shifting == false)
        {
            transform.localPosition = Vector3.MoveTowards(
                transform.localPosition,
                initialPosition,
                speed * Time.deltaTime);
        }
    }
}
