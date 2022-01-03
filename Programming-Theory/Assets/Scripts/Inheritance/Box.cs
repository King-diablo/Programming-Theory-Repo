using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Box : Shape
{
    public override void ShapeName()
    {
        m_ShapeName = "Box";
    }

    public override void ShapeColor()
    {
        colorName = "Blue";
    }
}
