using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sphere : Shape
{
    public float radius;

    public override void ShapeName()
    {
        shapeName = "Sphere";
    }

    public override void ShapeColor()
    {
        colorName = "Green";
    }
}
