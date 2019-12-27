using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasView : MonoBehaviour
{
    public GameObject figureChoosePanel;
    public GameObject colorChoosePanel;

    public GameObject blackColorLabel;
    public GameObject yellowColorLabel;
    public GameObject whiteColorLabel;

    public void DoVisibleColorPanel()
    {
        colorChoosePanel.SetActive(true);
        figureChoosePanel.SetActive(false);


    }
    public void DoVisibleChoosePanel()
    {
        colorChoosePanel.SetActive(false);
        figureChoosePanel.SetActive(true);
    }

    public void DoVisibleActiveColor(string activeColor)
    {
        blackColorLabel.SetActive(false);
        yellowColorLabel.SetActive(false);
        whiteColorLabel.SetActive(false);

        if (activeColor == "black")
            blackColorLabel.SetActive(true);
        if (activeColor == "yellow")
            yellowColorLabel.SetActive(true);
        if (activeColor == "white")
            whiteColorLabel.SetActive(true);
    }
}
