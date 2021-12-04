using UnityEngine;

public class GetObstaclePosition : MonoBehaviour
{
    float[,] obstaclePos = new float[7, 2];
    int numberOfObstacles = 7;

    public void GetPosition()
    {
        for (int i = 0; i < numberOfObstacles; i++)
        {
            GameObject player = GameObject.Find("Cube" + i);
            Transform playerTransform = player.transform;

            // get player position
            Vector3 position = playerTransform.position;

            
            obstaclePos[i, 0] = (float)decimal.Parse(position.x.ToString("0.00"));
            obstaclePos[i, 1] = (float)decimal.Parse(position.z.ToString("0.00"));

        }

        for (int i = 0; i < numberOfObstacles; i++)
        {
            Debug.Log("position of '" + obstaclePos[i, 0]);
            Debug.Log("position of '" + obstaclePos[i, 1]);
        }

    }

    void CreateArrayWithPos(float x, float z)
    {
        float[] xzPos = { x, z };






    }
}
