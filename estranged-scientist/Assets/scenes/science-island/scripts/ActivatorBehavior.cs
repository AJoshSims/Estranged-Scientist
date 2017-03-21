using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

/// <summary>
/// Defines the behavior of the activator objects which server as the
/// interface to the interactions in this game.
/// </summary>
public class ActivatorBehavior : MonoBehaviour
{
    ///<summary>
    /// The character whom the player is controlling from first person
    /// perspective.
    /// </summary>
    private GameObject larry;

    /// <summary>
    /// The object which is shifted when the activator is interacted with.
    /// </summary>
    public Shift shiftObject;

    /// <summary>
    /// The button atop the activator which shifts upon interaction with the
    /// activator.
    /// </summary>
    public Shift button;

    /// <summary>
    /// Gets Larry so that the activator can know when he is close by.
    /// </summary>
    private  void Awake()
    {
        larry = GameObject.Find("Larry");
    }

    /// <summary>
    /// When Larry is close enough to the activator, and when Larry presses
    /// the Activate button, the shiftable object will shift and the button
    /// will as well.
    /// </summary>
    private void Update()
    {
        if (((button.transform.position - larry.transform.position).magnitude 
            < 2) 
            && Input.GetButtonDown("Activate"))
        {
            shiftObject.ToggleShifting();
            button.ToggleShifting();
        }
    }
}
