using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoverRotate : MonoBehaviour
{
        public float xSpeed = 0.0f;
    public float ySpeed = 0.2f;
    public float zSpeed = 0.0f;
    bool rotateAllowed = false;

    private void Update() {
        if (rotateAllowed){
        transform.Rotate(xSpeed, ySpeed, zSpeed);
        }
    }

    private void OnMouseEnter() {
        rotateAllowed = true;

    }

    private void OnMouseExit() {
        rotateAllowed = false;
    }
}
