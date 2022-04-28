using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CanvasManager : MonoBehaviour
{
    public static CanvasManager Instance;

    public Text text1;
    public Text text2;
    public Text text3;
    public Text text4;

    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(this);
        }
    }

    public void Traduccion(Traducciones item)
    {
        text1.text = item.text1;
        text2.text = item.text2;
        text3.text = item.text3;
        text4.text = item.text4;
    }   
}