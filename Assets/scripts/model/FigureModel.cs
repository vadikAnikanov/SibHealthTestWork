using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FigureModel : MonoBehaviour
{
    public FigureView figureview;

    void Awake()
    {
        figureview = GetComponent<FigureView>();
    }

    public void SetColor(Color color)
    {
        SaveManager.instance.SetSaveColor(gameObject.name, color);

        figureview.SetFigureColor(color);
    }
    public Color GetColor()
    {
        return figureview.GetColor();
    }

    public void SetColorOnStart(string color)
    {

        if (color == "white")
        {
            figureview.SetFigureColor(Color.white);
        }
        if (color == "black")
        {
            figureview.SetFigureColor(Color.black);
        }
        if (color == "yellow")
        {
            figureview.SetFigureColor(Color.yellow);
        }
    }
}

