using UnityEngine;
using UnityEngine.InputSystem;

public class TestGamepadInput : MonoBehaviour
{
    private PlayerControls inputActions;
    private Vector2 leftStickInput;
    private Vector2 rightStickInput;

    private void Awake()
    {
        inputActions = new PlayerControls();

        inputActions.Player.Move.performed += ctx => leftStickInput = ctx.ReadValue<Vector2>();
        inputActions.Player.Move.canceled += ctx => leftStickInput = Vector2.zero;

        inputActions.Player.Look.performed += ctx => rightStickInput = ctx.ReadValue<Vector2>();
        inputActions.Player.Look.canceled += ctx => rightStickInput = Vector2.zero;
    }

    private void OnEnable()
    {
        inputActions.Player.Enable();
    }

    private void OnDisable()
    {
        inputActions.Player.Disable();
    }

    private void Update()
    {
        Debug.Log($"Left Stick: {leftStickInput}");
        Debug.Log($"Right Stick: {rightStickInput}");
    }
}
