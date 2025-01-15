using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PassLevel : MonoBehaviour
{
    
    [Header ("Level count (DO NOT EDIT)")]
    public int level_count = 0;
    public delegate void LevelPassed();
    public event LevelPassed OnLevelPassed;

    // private List<GameObject> doors;
    private int door_count = 1;
    // Start is called before the first frame update
    void Start()
    {
        // doors = new List<GameObject>(GameObject.FindGameObjectsWithTag("Doors"));
        // doors.Reverse();
    }

    // Update is called once per frame
    void Update()
    {
        if (level_count % 3 == 0 && level_count > 0)
        {
            Debug.Log("Level " + door_count + " passed");
            Destroy(GameObject.FindGameObjectWithTag("Door" + door_count));
            ++door_count;
            level_count = 0;
            OnLevelPassed();
        } // SI QUIERO QUE LOS NIVELES TENGAN DISTINTO NUMERO DE DIANAS HACERLO CON LA FORMA Q ESTA ABAJO
        // if (level_count == 3 && GameObject.FindGameObjectWithTag("FirstDoor") != null)
        // {
        //     Debug.Log("Level 1 passed");
        //     Destroy(GameObject.FindGameObjectWithTag("FirstDoor"));
        // } // AUMENTAR DEPENDIENDO DE EL NUMERO DE PUERTAS
        // if (level_count == 6 && GameObject.FindGameObjectWithTag("SecondDoor") != null)
        // {
        //     Debug.Log("Level 2 passed");
        //     Destroy(GameObject.FindGameObjectWithTag("SecondDoor"));
        // }
    }
}
