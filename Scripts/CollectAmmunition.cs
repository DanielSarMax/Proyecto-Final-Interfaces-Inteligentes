using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class CollectAmmunition : MonoBehaviour
{
    List<GameObject> ammunitions;
    private PlayerControls inputActions;
    private bool collectPressed = false;
    public float collection_range = 5.0f;
    [Header ("Ammunition count (DO NOT EDIT)")]
    public int ammunition_count = 0;
    // Start is called before the first frame update
    void Start()
    {
        ammunitions = new List<GameObject>(GameObject.FindGameObjectsWithTag("Ammunition"));
        inputActions = new PlayerControls();

        inputActions.Player.Collect.performed += ctx => collectPressed = true;
        inputActions.Player.Collect.canceled += ctx => collectPressed = false;

        inputActions.Player.Enable();
    }

    private void OnDisable()
    {
        inputActions.Player.Disable();
    }

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < ammunitions.Count; i++)
        {
            GameObject ammunition = ammunitions[i];
            if (Vector3.Distance(ammunition.transform.position, transform.position) < collection_range && collectPressed)
            {
                Destroy(ammunition);
                ammunitions.RemoveAt(i);
                ammunition_count += 5;
                Debug.Log("Ammunition collected");
                Debug.Log("Ammunition count: " + ammunition_count);
            }
        }
    }
}