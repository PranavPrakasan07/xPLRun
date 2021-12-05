using UnityEngine;

public class GetObstaclePosition : MonoBehaviour
{
    const int numberOfObstacles = 7;
    float[,] obstaclePos = new float[numberOfObstacles + 2, 2];

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
        obstaclePos[numberOfObstacles, 0] = (float)decimal.Parse(playerPosition.z.ToString("0.00"));
        obstaclePos[numberOfObstacles, 1] = (float)decimal.Parse(playerPosition.z.ToString("0.00"));

        for (int i = 1; i < numberOfObstacles + 1; i++)
        {

            GameObject obstacle = GameObject.Find("Cube" + i);
            Transform obstacleTransform = obstacle.transform;

            // get obstacle position
            Vector3 obstaclePosition = obstacleTransform.position;


            obstaclePos[i, 0] = (float)decimal.Parse(obstaclePosition.x.ToString("0.00"));
            obstaclePos[i, 1] = (float)decimal.Parse(obstaclePosition.z.ToString("0.00"));

        }


        for (int i = 0; i < numberOfObstacles + 1; i++)
        {
            Debug.Log("position of '" + i + ":" + obstaclePos[i, 0]);
            Debug.Log("position of '" + i + ":" + obstaclePos[i, 1]);
        }

    }

    void CreateArrayWithPos(float x, float z)
    {
        float[] xzPos = { x, z };






    }
}
