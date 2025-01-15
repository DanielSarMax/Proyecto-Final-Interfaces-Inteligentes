using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class GoToNextLevel : MonoBehaviour
{
    public PassLevel passLevel;
    // Start is called before the first frame update
    void Start()
    {
        passLevel.OnLevelPassed += TeleportToNextLevel;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void TeleportToNextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
