using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaintController : MonoBehaviour
{
    private GameObject _selectedObject;
    public static PaintController instance;

    private void Start()
    {
        if (instance == null)
        {
            instance = this;
        }
        else if (instance == this)
        {
            Destroy(gameObject);
        }
    }

    public string GetNameSelectedObject()
    {
        if(_selectedObject == null)
        {
            return null;
        }

        return _selectedObject.gameObject.name;
    }

    public void SetSelectedObject(GameObject selectedObject)
    {
        _selectedObject = selectedObject;
    }

    public void SetWhiteColor()
    {
        if (_selectedObject == null)
        {
            return;
        }

        _selectedObject.GetComponent<FigureModel>().SetColor(Color.white);
    }

    public void SetYellowColor()
    {
        if (_selectedObject == null)
        {
            return;
        }

        _selectedObject.GetComponent<FigureModel>().SetColor(Color.yellow);
    }

    public void SetBlackColor()
    {
        if (_selectedObject == null)
        {
            return;
        }

        _selectedObject.GetComponent<FigureModel>().SetColor(Color.black);
    }
}
