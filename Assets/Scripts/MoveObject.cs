using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObject : MonoBehaviour
{
    public float xPosition = 0.0f;

    public GameObject Object;
    Vector3 currentPosition;
    private void Start()
    {
        currentPosition = transform.position;

        Debug.Log("currentPosition:" + currentPosition);
        Debug.Log("givenPosition:" + xPosition);

        Object.transform.position = new Vector3(currentPosition.x + xPosition, currentPosition.y, currentPosition.z);
        Debug.Log("currentPosition:" + currentPosition);
    }

    private void Update()
    {
        // Debug.Log("currentPosition:" + currentPosition);
        // Debug.Log("givenPosition:" + xPosition);
    }

    public void MovechosenObject(float x)
    {
        Debug.Log("currentPosition:" + transform.position);
    }


}
