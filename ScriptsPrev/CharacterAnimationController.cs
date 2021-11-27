using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Character))]
public class CharacterAnimationController : MonoBehaviour
{

    private Character character;

    public Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        character = GetComponent<Character>();
    }

    // Update is called once per frame
    void Update()
    {
        if (animator == null)
        {
            Debug.LogWarning("No valid Animator");
            return;
        }

        animator.SetFloat("Velocity", character.getVelocity());
    }

    public void SetMovementMode(MovementMode mode)
    {

        switch (mode)
        {
            case MovementMode.Walking:
                {
                    animator.SetInteger("movement state", 0);
                    break;
                }

            case MovementMode.Running:
                {
                    animator.SetInteger("movement state", 0);
                    break;
                }
            case MovementMode.Crouching:
                {
                    animator.SetInteger("movement state", 1);
                    break;
                }
            case MovementMode.Proning:
                {
                    animator.SetInteger("movement state", 2);
                    break;
                }
            case MovementMode.Swimming:
                {
                    animator.SetInteger("movement state", 3);
                    break;
                }
            case MovementMode.Sprinting:
                {
                    animator.SetInteger("movement state", 4);
                    break;
                }
            case MovementMode.Pressing:
                {
                    animator.SetInteger("movement state", 5);
                    break;
                }
            case MovementMode.Sitting:
                {
                    animator.SetInteger("movement state", 6);
                    break;
                }
        }

    }
}
