using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shift : MonoBehaviour
{
    private bool shifting;

    public float speed;

    private Vector3 initialLocalPosition;

    public float maxShiftedLocalPositionX;

    public float maxShiftedLocalPositionY;

    public float maxShiftedLocalPositionZ;

    private Vector3 maxShiftedLocalPosition;

    private void Awake()
    {
        shifting = false;

        initialLocalPosition = transform.localPosition;

        maxShiftedLocalPosition = new Vector3(
            maxShiftedLocalPositionX,
            maxShiftedLocalPositionY,
            maxShiftedLocalPositionZ);
    }

    internal void toggleShifting()
    {
        shifting = !shifting;
    }

    protected void Update()
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
                initialLocalPosition,
                speed * Time.deltaTime);
        }
    }
}
