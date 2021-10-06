using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Runtime.InteropServices;

public class URLOpenner : MonoBehaviour
{
    public string Url;

    [DllImport("__Internal")]
    private static extern void OpenNewTab(string url);

    public void openIt(string url)
    {
        #if !UNITY_EDITOR && UNITY_WEBGL
        OpenNewTab(url);
        #endif
    }


    private void OnMouseDown() {
        //Open();
        openIt(Url);

    }

    public void Open(){

        openIt(Url);


        // try{
        //     Application.ExternalEval("window.open('" + Url + "','_blank')");
        // }
        // catch{
        //     Application.OpenURL(Url);
        // }

        //Application.ExternalEval("window.open(\"http://www.unity3d.com\",\"_blank\")");
    }
    
    // void Update()
    // {
    //     if (Input.GetKeyDown(KeyCode.Return))
    //     {
    //         openIt(Url);
    //     }
    // }
}

