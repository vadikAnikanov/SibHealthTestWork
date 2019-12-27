using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasModel : MonoBehaviour
{
    private CanvasView canvasView;

    void Start()
    {
        canvasView = GetComponent<CanvasView>();
    }

    public void OnClickChooseSomeFigure()
    {
        canvasView.DoVisibleColorPanel();

        DoVisibleSelectedColorLabel();
    }

    public void DoVisibleSelectedColorLabel()
    {
        string selectedFigureName = PaintController.instance.GetNameSelectedObject();

        string chosedColor = SaveManager.instance.Getcolor(selectedFigureName);

        canvasView.DoVisibleActiveColor(chosedColor);
    }

    public void OnClickBackToFigures()
    {
        canvasView.DoVisibleChoosePanel();
    }
}
