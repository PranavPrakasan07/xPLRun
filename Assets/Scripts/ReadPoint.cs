using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

public class ReadPoint : MonoBehaviour
{

    private string input;

    [DllImport("__Internal")]
    private static extern void SetFinishPoint(string finish);

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ReadStringInput(string s)
    {
        input = s;
        Debug.Log(input);

        SetFinishPoint(input);
    } 
}
