using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IconRotator : MonoBehaviour
{

    public float xSpeed = 0.0f;
    public float ySpeed = 0.3f;
    public float zSpeed = 0.0f;
    public float ySpeedRotationOffset = 0.1f;

    private void Start() {
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(xSpeed, ySpeed + ySpeedRotationOffset, zSpeed);
    }


}
