using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class UIcontrol : MonoBehaviour
{
    public TMP_Text targetText, ammoText, levelText; 
    public PassLevel passLevel;
    public CollectAmmunition collectAmmunition;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        targetText.text = "Targets: " + passLevel.level_count + " / 3";
        ammoText.text = "Ammo: " + collectAmmunition.ammunition_count;
        levelText.text = "Level: " + (SceneManager.GetActiveScene().buildIndex + 1) + " / 3";
    }
}
