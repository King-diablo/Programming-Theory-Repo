using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Shape : MonoBehaviour
{
    private string shapeName;// INHERITANCE
    public string m_ShapeName// ENCAPSULATION”
    {
        get 
        { 
            return shapeName; 
        }
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
    private string colorName;// INHERITANCE
    public string m_ColorName { get { return colorName; } set { if (colorName == null) { colorName = "Black"; } else { colorName = value; } } }
    private Vector3 size;// INHERITANCE
    public Vector3 m_ShapeSize // ENCAPSULATION”
    {
        get
        {
            return size;
        }
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

    // POLYMORPHISM overriding
    public abstract void ShapeName();


    // POLYMORPHISM overriding
    public abstract void ShapeColor();

    public abstract void ShapeSize();

    public abstract void Reshape();

    public abstract void SayMyName();

    public abstract void WhatsMyColor();



    /*we can override shapename and colorname because they are unique in that aspect
 but the size we want all the children to have te same size*/
}
