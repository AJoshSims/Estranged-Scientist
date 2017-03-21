using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Allows an object to be shifted away from and back to its original 
/// position.
/// </summary>
public class Shift : MonoBehaviour
{
    /// <summary>
    /// Is the object currently shifting away from its original position.
    /// </summary>
    private bool shiftingAway;

    /// <summary>
    /// The speed at which the object shifts.
    /// </summary>
    public float speed;

    /// <summary>
    /// The original position of the object.
    /// </summary>
    private Vector3 originalLocalPosition;

    /// <summary>
    /// The maximum X position that the object may shift to.
    /// </summary>
    public float maxShiftedLocalPositionX;

    /// <summary>
    /// The maximum Y position that the object may shift to.
    /// </summary>
    public float maxShiftedLocalPositionY;

    /// <summary>
    /// The maximum Z position that the object may shift to.
    /// </summary>
    public float maxShiftedLocalPositionZ;

    /// <summary>
    /// The maximum position that the object may shift to.
    /// </summary>
    private Vector3 maxShiftedLocalPosition;

    /// <summary>
    /// Establishes the object's original position, that it is not shifting
    /// away yet, and what its maximum shifted position is.
    /// </summary>
    private void Awake()
    {
        shiftingAway = false;

        originalLocalPosition = transform.localPosition;

        maxShiftedLocalPosition = new Vector3(
            maxShiftedLocalPositionX,
            maxShiftedLocalPositionY,
            maxShiftedLocalPositionZ);
    }

    /// <summary>
    /// Provokes the object to shift either away from or back to its original
    /// position.
    /// </summary>
    internal void ToggleShifting()
    {
        shiftingAway = !shiftingAway;
    }

    /// <summary>
    /// Shifts the object either away from or back to its original position.
    /// </summary>
    protected void Update()
    {
        if (shiftingAway == true)
        {
            transform.localPosition = Vector3.MoveTowards(
                transform.localPosition,
                maxShiftedLocalPosition,
                speed * Time.deltaTime);
        }

        else if (shiftingAway == false)
        {
            transform.localPosition = Vector3.MoveTowards(
                transform.localPosition,
                originalLocalPosition,
                speed * Time.deltaTime);
        }
    }
}
