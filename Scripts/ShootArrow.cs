using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class ShootArrow : MonoBehaviour
{
    public GameObject arrowPrefab; // Prefab de la flecha
    public Transform arrowSpawnPoint; // Punto de aparición de la flecha
    public float maxChargeTime = 2.0f; // Tiempo máximo de carga
    public float maxArrowSpeed = 50.0f; // Velocidad máxima de la flecha
    public Transform playerTransform; // Transform del jugador

    private PlayerControls inputActions;
    private float chargeTime = 0.0f;
    private bool isCharging = false;
    private CollectAmmunition ammunition;

    private void Awake()
    {
        inputActions = new PlayerControls();

        inputActions.Player.Shoot.performed += ctx => StartCharging();
        inputActions.Player.Shoot.canceled += ctx => LaunchArrow();

        ammunition = GetComponent<CollectAmmunition>();
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
        if (isCharging)
        {
            chargeTime += Time.deltaTime;
            chargeTime = Mathf.Clamp(chargeTime, 0, maxChargeTime);
        }
    }

    private void StartCharging()
    {
        if (ammunition != null && ammunition.ammunition_count > 0)
        {
            isCharging = true;
            chargeTime = 0.0f;
        }
        else
        {
            Debug.Log("No hay suficiente munición para disparar");
        }
    }

    private void LaunchArrow()
    {
        if (isCharging)
        {
            isCharging = false;

            // Desplazamiento hacia adelante desde el punto de aparición
            Vector3 spawnPosition = arrowSpawnPoint.position + arrowSpawnPoint.forward * 0.75f; // Ajusta el valor 0.5f según sea necesario

            // Crear la flecha con la rotación del jugador
            GameObject arrow = Instantiate(arrowPrefab, spawnPosition, playerTransform.rotation);
            arrow.transform.rotation = Quaternion.Euler(90, playerTransform.rotation.eulerAngles.y, arrow.transform.rotation.eulerAngles.z);

            // Calcular la velocidad de la flecha
            float arrowSpeed = (chargeTime / maxChargeTime) * maxArrowSpeed;

            // Aplicar la velocidad a la flecha
            Rigidbody rb = arrow.GetComponent<Rigidbody>();
            rb.velocity = playerTransform.forward * arrowSpeed;

            // Reducir la munición
            ammunition.ammunition_count--;

            // Reiniciar el tiempo de carga
            chargeTime = 0.0f;

            Debug.Log("Flecha disparada. Munición restante: " + ammunition.ammunition_count);
        }
    }
}