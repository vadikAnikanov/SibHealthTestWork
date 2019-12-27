using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FigureView : MonoBehaviour
{
    private Renderer render;

    void Awake()
    {
        render = GetComponent<Renderer>();        
    }

    public void SetFigureColor(Color color)
    {
        render.material.SetColor("_Color", color);
    }
    public Color GetColor()
    {
        return render.material.color;
    }
}
