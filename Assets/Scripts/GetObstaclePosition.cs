using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.UI;

public class GetObstaclePosition : MonoBehaviour
{
    const int numberOfObstacles = 7;
    float[,] obstaclePos = new float[numberOfObstacles + 1, 2];
    public string posString = "";

    [DllImport("__Internal")]
    private static extern void Hello();

    [DllImport("__Internal")]
    private static extern void HelloString(string str);

    [DllImport("__Internal")]
    private static extern void GetPos(string posString);

    public void GetPosition()
    {
        GameObject player = GameObject.Find("Character");
        Transform playerTransform = player.transform;

        // get player position
        Vector3 playerPosition = playerTransform.position;

        //Player start
        obstaclePos[0, 0] = (float)decimal.Parse(playerPosition.x.ToString("0.00"));
        obstaclePos[0, 1] = (float)decimal.Parse(playerPosition.z.ToString("0.00"));

        //Player end
        //obstaclePos[numberOfObstacles, 0] = (float)decimal.Parse(playerPosition.z.ToString("0.00"));
        //obstaclePos[numberOfObstacles, 1] = (float)decimal.Parse(playerPosition.z.ToString("0.00"));

        for (int i = 1; i < numberOfObstacles+1; i++)
        {
            posString = "";

            GameObject obstacle = GameObject.Find("Cube" + i);
            Transform obstacleTransform = obstacle.transform;

            // get obstacle position
            Vector3 obstaclePosition = obstacleTransform.position;

            obstaclePos[i, 0] = (float)decimal.Parse(obstaclePosition.x.ToString("0.00"));
            obstaclePos[i, 1] = (float)decimal.Parse(obstaclePosition.z.ToString("0.00"));

        }


        for (int i = 1; i < numberOfObstacles + 1; i++)
        {
            Debug.Log("position of '" + i + ":" + obstaclePos[i, 0]);
            Debug.Log("position of '" + i + ":" + obstaclePos[i, 1]);
            posString += " \"" + i + "\": [" + obstaclePos[i, 0] + ","  + obstaclePos[i, 1] + "],";
        }

        var posDictionary = "{ \"start\":[" + obstaclePos[0, 0] + "," + obstaclePos[0, 1] + "]," + posString;

        GetPos(posDictionary);
    }


    void Start()
    {

        //HelloString("This is a string.");

        //float[] myArray = new float[10];
        //PrintFloatArray(myArray, myArray.Length);

        //int result = AddNumbers(5, 7);
        //Debug.Log(result);

        //Debug.Log(StringReturnValueFunction());

    }
}
