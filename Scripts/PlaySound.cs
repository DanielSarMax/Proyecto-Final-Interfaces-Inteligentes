using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySound : MonoBehaviour
{
    public AudioClip backgroundMusic; // Clip de audio de fondo
    private AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        // Obtener o añadir el componente AudioSource
        audioSource = GetComponent<AudioSource>();
        if (audioSource == null)
        {
            audioSource = gameObject.AddComponent<AudioSource>();
        }

        // Asignar el clip de audio y configurar el AudioSource
        audioSource.clip = backgroundMusic;
        audioSource.loop = true; // Reproducir en bucle
        audioSource.playOnAwake = true; // Reproducir al iniciar la escena

        // Reproducir el sonido de fondo
        audioSource.Play();
    }
}