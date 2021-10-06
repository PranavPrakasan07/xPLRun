using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Character : MonoBehaviour
{

    private float forwardInput;
    private float rightInput;
    private Vector3 velocity;

    public CameraController cameraController;
    public CharacterMovement characterMovement;
    public CharacterAnimationController characterAnimation;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //transform.Translate(velocity);
    }

    public void AddMovementInput(float forward, float right)
    {
        forwardInput = forward;
        rightInput = right;

        Vector3 camFwd = cameraController.transform.forward;
        Vector3 camRight = cameraController.transform.right;

        //* 0.5f  * 0.5f

        Vector3 translation = forward * cameraController.transform.forward;
        translation += right * cameraController.transform.right;

        translation.y = 0;

        if (translation.magnitude > 0)
        {
            velocity = translation;
        }
        else
        {
            velocity = Vector3.zero;
        }

        characterMovement.Velocity = translation;
    }

    public float getVelocity()
    {
        //Debug.Log(velocity.magnitude);
        return characterMovement.Velocity.magnitude;
    }

    public void ToggleRun()
    {
        if (characterMovement.GetMovementMode() != MovementMode.Running)
        {
            characterMovement.SetMovementMode(MovementMode.Running);
            characterAnimation.SetMovementMode(MovementMode.Running);
        }
        else
        {
            characterMovement.SetMovementMode(MovementMode.Walking);
            characterAnimation.SetMovementMode(MovementMode.Walking);

        }
    }

    public void ToggleCrouching()
    {
        if (characterMovement.GetMovementMode() != MovementMode.Crouching)
        {
            characterMovement.SetMovementMode(MovementMode.Crouching);
            characterAnimation.SetMovementMode(MovementMode.Crouching);
        }
        else
        {
            characterMovement.SetMovementMode(MovementMode.Walking);
            characterAnimation.SetMovementMode(MovementMode.Walking);
        }

    }

    public void TogglePressing()
    {
        if (characterMovement.GetMovementMode() != MovementMode.Pressing)
        {
            characterMovement.SetMovementMode(MovementMode.Pressing);
            characterAnimation.SetMovementMode(MovementMode.Pressing);
        }
        else
        {
            characterMovement.SetMovementMode(MovementMode.Walking);
            characterAnimation.SetMovementMode(MovementMode.Walking);
        }

    }

    public void ToggleSitting()
    {
        if (characterMovement.GetMovementMode() != MovementMode.Sitting)
        {
            characterMovement.SetMovementMode(MovementMode.Sitting);
            characterAnimation.SetMovementMode(MovementMode.Sitting);
        }
        else
        {
            characterMovement.SetMovementMode(MovementMode.Walking);
            characterAnimation.SetMovementMode(MovementMode.Walking);
        }

    }

}
