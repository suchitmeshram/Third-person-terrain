using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AgentController : MonoBehaviour
{
    IInput input;
    AgentMovement movement;

    private void OnEnable()
    {
        input = GetComponent<IInput>();
        movement = GetComponent<AgentMovement>();
        input.OnMovementDIrectionInput += movement.HandleMovementDirection;
        input.OnMovementInput += movement.HandleMovement;
    }

    private void OnDisable() 
    {
        input.OnMovementDIrectionInput -= movement.HandleMovementDirection;
        input.OnMovementInput -= movement.HandleMovement;
    }


}
