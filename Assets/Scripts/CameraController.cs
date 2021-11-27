using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    private Quaternion camRotation;

    public float cameraSmootheningFactor = 2;
    public float lookUpMax = 45;
    public float lookUpMin = -45;
    
    // Start is called before the first frame update
    void Start()
    {
        camRotation = transform.localRotation;
    }

    // Update is called once per frame
    void Update()
    {
        
        camRotation.x += Input.GetAxis("Mouse Y") * cameraSmootheningFactor * (-1); // Look up/down // -1 multiplied to invert rotation
        camRotation.y += Input.GetAxis("Mouse X") * cameraSmootheningFactor * (1); // Look left/right // -1 multiplied to invert rotation

        camRotation.x = Mathf.Clamp(camRotation.x, lookUpMin, lookUpMax);


        transform.localRotation = Quaternion.Euler(camRotation.x, camRotation.y, camRotation.z);
    }
}
