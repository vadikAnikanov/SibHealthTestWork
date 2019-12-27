using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CameraModel : MonoBehaviour
{
    private CameraView cameraview;

    void Start()
    {
        cameraview = GetComponent<CameraView>();
    }

    public void OnSomeFigureChooseClick(GameObject figure)
    {
        Vector3 figurePos = figure.transform.position;

        cameraview.SetTargetPos(figurePos);
    }
    
    public void OnClickToBack()
    {
        cameraview.SetStartPos();
    }
}
