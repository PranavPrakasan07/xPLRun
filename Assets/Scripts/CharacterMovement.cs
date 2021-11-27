using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum MovementMode { Walking, Running, Crouching, Proning, Swimming, Sprinting, Pressing, Sitting };

[RequireComponent(typeof(Rigidbody))]
public class CharacterMovement : MonoBehaviour
{
    private Vector3 velocity;
    private float smoothSpeed;
    private Rigidbody rigidbody;
    private MovementMode movementMode;

    public Transform t_mesh;
    public float maxSpeed = 0.05f;
    public float rotationSpeed = 100;

    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        //transform.Translate(velocity.normalized*maxSpeed);   


        if (velocity.magnitude > 0)
        {
            rigidbody.velocity = new Vector3(velocity.normalized.x * smoothSpeed, velocity.normalized.y * smoothSpeed, velocity.normalized.z * smoothSpeed);
            smoothSpeed = Mathf.Lerp(smoothSpeed, maxSpeed, Time.deltaTime);
            // t_mesh.rotation = Quaternion.LookRotation(velocity);        
            t_mesh.rotation = Quaternion.Lerp(t_mesh.rotation, Quaternion.LookRotation(velocity), Time.deltaTime * rotationSpeed);

        }
        else
        {
            smoothSpeed = Mathf.Lerp(smoothSpeed, 0, Time.deltaTime);
        }
    }

    public Vector3 Velocity { get => rigidbody.velocity; set => velocity = value; }

    public void SetMovementMode(MovementMode mode)
    {

        movementMode = mode;

        switch (mode)
        {
            case MovementMode.Walking:
                {
                    maxSpeed = 10;
                    break;
                }

            case MovementMode.Running:
                {
                    maxSpeed = 15;
                    break;
                }
            case MovementMode.Crouching:
                {
                    maxSpeed = 5;
                    break;
                }
            case MovementMode.Proning:
                {
                    maxSpeed = 2;
                    break;
                }
            case MovementMode.Swimming:
                {
                    maxSpeed = 5;
                    break;
                }
            case MovementMode.Sprinting:
                {
                    maxSpeed = 20;
                    break;
                }

        }
    }

    public MovementMode GetMovementMode()
    {
        return movementMode;
    }

}
