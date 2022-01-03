using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shape : MonoBehaviour
{
    private string shapeName;// INHERITANCE
    public string m_ShapeName
    {
        set
        {
            if (value == null)
            {
                Debug.Log("Name cannot be empty");
            }
            else
            {
                shapeName = value;
            }
        }
    }
    public string colorName;// INHERITANCE
    private Vector3 size;// INHERITANCE
    public Vector3 m_ShapeSize 
    {
        set
        {
            if (value == Vector3.zero)
            {
                value = Vector3.one;
            }
            else
            {
                size = value;
            }
        }
    }


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
