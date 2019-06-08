﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineManagerScript : MonoBehaviour
{

    // Draws a line from "startVertex" var to the curent mouse position.
    Material mat;
    Vector3 startVertex;
    Vector3 mousePos;

    // Start is called before the first frame update
    void Start()
    {
        startVertex = Vector3.zero;
    }

    // Update is called once per frame
    void Update()
    {
        mousePos = Input.mousePosition;
        // Press space to update startVertex
        if (Input.GetKeyDown(KeyCode.Space))
        {
            startVertex = new Vector3(mousePos.x / Screen.width, mousePos.y / Screen.height, 0);
        }
    }

    //..
    void OnPostRender()
    {
        if (!mat)
        {
            Debug.LogError("Please Assign a material on the inspector");
            return;
        }
        GL.PushMatrix();
        mat.SetPass(0);
        GL.LoadOrtho();

        GL.Begin(GL.LINES);
        GL.Color(Color.red);
        GL.Vertex(startVertex);
        GL.Vertex(new Vector3(mousePos.x / Screen.width, mousePos.y / Screen.height, 0));
        GL.End();

        GL.PopMatrix();
    }

}
