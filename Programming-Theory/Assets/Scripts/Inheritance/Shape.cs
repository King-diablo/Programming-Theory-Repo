using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shape : MonoBehaviour
{
    public string shapeName;// INHERITANCE
    public string colorName;// INHERITANCE
    public Vector3 size;// INHERITANCE


    private void Update()
    {
        ShapeName();
        ShapeName(shapeName);
        ShapeColor();
        ShapeColor(colorName);
        ShapeSize();
    }

    // POLYMORPHISM overriding
    public virtual void ShapeName()
    {
        Debug.Log($"Hello I Am A {shapeName}");
    }

    // POLYMORPHISM overloading
    public virtual void ShapeName(string name)
    {
        Debug.Log($"Hello I Am A {name}");
    }

    // POLYMORPHISM overriding
    public virtual void ShapeColor()
    {
        Debug.Log($"Hi My Color Is {colorName}");
    }
    // POLYMORPHISM overloading
    public virtual void ShapeColor(string color)
    {
        Debug.Log($"Hi My Color Is {color}");
    }

    void ShapeSize()
    {
        size = Vector3.one;
    }

    /*we can override shapename and colorname because they are unique in that aspect
 but the size we want all the children to have te same size*/
}
