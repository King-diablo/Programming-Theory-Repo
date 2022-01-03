using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Caller : MonoBehaviour
{
    public List<Shape> shapes;

    private void Start()
    {
        
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            foreach (Shape shape in shapes)
            {
                shape.SayMyName();
            }
        }
        if (Input.GetMouseButtonDown(1))
        {
            foreach (Shape shape in shapes)
            {
                shape.WhatsMyColor();
            }
        }
        if (Input.GetKeyDown(KeyCode.Y))
        {
            foreach (Shape shape in shapes)
            {
                shape.Reshape();
            }
        }

    }
}
