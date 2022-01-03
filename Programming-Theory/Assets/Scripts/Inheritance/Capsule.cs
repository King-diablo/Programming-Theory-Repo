using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Capsule : Shape
{
    public override void ShapeName()
    {
        m_ShapeName = "Capsule";
    }

    public override void ShapeColor()
    {
        colorName = "Red";
    }
}
