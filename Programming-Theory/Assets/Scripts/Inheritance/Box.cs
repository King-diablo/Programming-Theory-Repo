using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Box : Shape
{
    private void Awake()
    {
        ShapeName();
        ShapeColor();
    }

    public override void ShapeName()
    {
        m_ShapeName = "Box";
        Debug.Log(m_ShapeName);
    }

    public override void ShapeColor()
    {
        m_ColorName = "Blue";
        Debug.Log(m_ColorName);
    }

    public override void SayMyName()
    {
        ShapeName();
    }
    public override void WhatsMyColor()
    {
        ShapeColor();
    }

    public override void ShapeSize()
    {
        m_ShapeSize = Vector3.one;
    }

    public override void Reshape()
    {
        m_ShapeSize = Vector3.one * 5;
        transform.position.Scale(m_ShapeSize);
    }
}
