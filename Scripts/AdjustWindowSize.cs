using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AdjustWindowSize : MonoBehaviour
{
    private int Width;
    private int Height;

    public void SetWidth(int width){
        Width = width;
    }

    public void SetHeight(int height){
        Height = height;
    }

    public void OnResize(int width, int height){
        Screen.SetResolution(width, height, false);
    }
}
