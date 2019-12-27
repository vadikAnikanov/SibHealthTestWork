using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveManager : MonoBehaviour
{
    public static SaveManager instance = null;

    public FigureModel[] AllFigureModel;

    void Start()
    {
        if (instance == null)
        {
            instance = this; 
        }
        else if (instance == this)
        { 
            Destroy(gameObject); 
        }

        AllFigureModel = FindObjectsOfType<FigureModel>();

        foreach (FigureModel figure in AllFigureModel)
        {
            /// figurename->color
            if (PlayerPrefs.HasKey(figure.gameObject.name))
            {
              figure.SetColorOnStart(PlayerPrefs.GetString(figure.gameObject.name));
            }
            else
            {
                PlayerPrefs.SetString(figure.gameObject.name, "white");
            }
        }
    }

    public void SetSaveColor(string figure,Color color)
    {
        if(color == Color.black)
        {
            PlayerPrefs.SetString(figure, "black");
        }

        if (color == Color.yellow)
        {
            PlayerPrefs.SetString(figure, "yellow");
        }

        if (color == Color.white)
        {
            PlayerPrefs.SetString(figure, "white");
        }
    }

    public string Getcolor(string figureName)
    {
       return PlayerPrefs.GetString(figureName);
    }
}
