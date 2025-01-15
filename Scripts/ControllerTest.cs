using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class ControllerTest : MonoBehaviour
{
    public float moveSpeed = 5.0f;       // Velocidad de movimiento
    public float teleportDistance = 10.0f; // Distancia máxima de teletransporte
    public Transform playerTransform; // Transform del jugador
    public AudioClip audioClip; // Sonido de teletransporte

    private PlayerControls inputActions;
    private Vector2 leftStickInput;
    private Rigidbody rb;
    private AudioSource audioSource;

    private void Awake()
    {
        // Inicializar el esquema de entrada
        inputActions = new PlayerControls();

        // Configurar las acciones
        inputActions.Player.Move.performed += ctx => leftStickInput = ctx.ReadValue<Vector2>();
        inputActions.Player.Move.canceled += ctx => leftStickInput = Vector2.zero;

        inputActions.Player.Teleport.performed += ctx => Teleport();

        // Obtener el Rigidbody
        rb = GetComponent<Rigidbody>();
        audioSource = GetComponent<AudioSource>();
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
        // Movimiento con el stick izquierdo
        Vector3 moveDirection = new Vector3(leftStickInput.x, 0, leftStickInput.y);
        moveDirection = playerTransform.TransformDirection(moveDirection);
        rb.MovePosition(rb.position + moveSpeed * Time.deltaTime * moveDirection);
    }

    private void Teleport()
    {
        // Realizar un Raycast hacia adelante desde la posición del jugador
        Ray ray = new Ray(playerTransform.position, playerTransform.forward);
        RaycastHit hit;
        Vector3 targetPosition;

        // Si el Raycast golpea algo dentro del rango de teletransporte, teletransportar al jugador a esa posición
        if (Physics.Raycast(ray, out hit, teleportDistance))
        {
            targetPosition = hit.point;
        }
        else
        {
            // Si no golpea nada, teletransportar al jugador a la distancia máxima
            targetPosition = playerTransform.position + playerTransform.forward * teleportDistance;
        }

        // Deshabilitar el Rigidbody temporalmente para evitar problemas de colisión
        rb.isKinematic = true;

        // Verificar si la nueva posición está dentro de los límites del mapa
        transform.position = targetPosition;

        // Habilitar el Rigidbody nuevamente
        rb.isKinematic = false;

        // Reproducir el sonido de teletransporte
        audioSource.PlayOneShot(audioClip);

        Debug.Log("Teleported to: " + transform.position);
    }
}