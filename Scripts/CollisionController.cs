using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionController : MonoBehaviour
{
    private PassLevel passLevel;
    // Start is called before the first frame update
    void Start()
    {
        passLevel = GameObject.FindGameObjectWithTag("LevelController").GetComponent<PassLevel>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        // Verificar si la colisión es con una flecha
        if (collision.gameObject.CompareTag("Arrow"))
        {
            Debug.Log("Flecha impactó con la diana");
            passLevel.level_count += 1;

            // Desactivar la física de la flecha
            Rigidbody arrowRigidbody = collision.gameObject.GetComponent<Rigidbody>();
            if (arrowRigidbody != null)
            {
                arrowRigidbody.velocity = Vector3.zero;
                arrowRigidbody.angularVelocity = Vector3.zero;
                arrowRigidbody.isKinematic = true;
            }

            // Hacer que la flecha se convierta en un hijo de la diana
            collision.gameObject.transform.SetParent(transform);

            // Desactivar la diana y destruirla después de un breve retraso
            gameObject.SetActive(false);
            Destroy(gameObject, 0.5f); // Ajusta el tiempo de retraso según sea necesario
        }
    }
}