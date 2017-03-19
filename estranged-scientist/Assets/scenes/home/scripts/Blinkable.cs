using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface Blinkable : Activatable
{
    Color OriginalColor
    {
        get;
    }

    void Blink(float duration, Color color);
}
