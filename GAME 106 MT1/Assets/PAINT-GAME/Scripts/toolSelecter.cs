using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class toolSelecter : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseDown()
    {
        if (gameObject.name == "eraser23")
        {
            PaintTry.toolType = "eraser";
            Debug.Log("ereser selected");
        
        }

        if (gameObject.name == "pencil23")
        {
            PaintTry.toolType = "pencil";
            Debug.Log("pencil selected");
        }
    }
}
