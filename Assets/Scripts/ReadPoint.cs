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

        //var engine = Python.CreateEngine();
        //ICollection<string> searchPaths = engine.GetSearchPaths();
        ////Path to the folder of test.py
        //searchPaths.Add(Application.dataPath);
        ////Path to the Python standard library
        //searchPaths.Add(Application.dataPath + @"\StreamingAssets" + @"\Lib\");
        //engine.SetSearchPaths(searchPaths);
        //dynamic py = engine.ExecuteFile(Application.dataPath + @"\StreamingAssets" + @"\Python\test.py");
        //dynamic test = py.Test("Codemaker");
        //Debug.Log("Greeting: " + test.display());
        //Debug.Log("Random Number: " + test.random_number(1, 5));
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
