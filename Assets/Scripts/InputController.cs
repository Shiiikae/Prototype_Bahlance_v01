using System;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;

[Serializable]
public class MoveInputEvent : UnityEvent<float, float> { }

public class InputController : MonoBehaviour
{
    PlayerControls controls;
    public MoveInputEvent moveInputEvent;

    private void Awake()
    {
        controls = new PlayerControls(); 
    }

    private void OnEnable()
    {
        controls.Player.Enable();
        controls.Player.Movement.performed += OnMovePerfomed;
        controls.Player.Movement.canceled += OnMovePerfomed;
    }

    private void OnMovePerfomed(InputAction.CallbackContext context)
    {
        Vector2 moveInput = context.ReadValue<Vector2>();
        moveInputEvent.Invoke(moveInput.x, moveInput.y);
        //Debug.Log($"Move Input: {moveInput}");
    }
}
