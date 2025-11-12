using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIHealth : MonoBehaviour
{
    [SerializeField] GameObject GameOverScreen;
    [SerializeField] TextMeshProUGUI SurvivedText;
    [SerializeField] float currentHealth = 0;

    private void Update()
    {
        if (currentHealth <= 0)
        {
            GameOverScreen.SetActive(true);
            Time.timeScale = 0;
            SurvivedText.text = "The Young wins!";
        }
    }

    /* Young
     private void Update()
    {
        if (currentHealth <= 0)
        {
            GameOverScreen.SetActive(true);
            Time.timeScale = 0;
            SurvivedText.text = "The Young wins!";
        }
    }
     */

    /* Old
     private void Update()
    {
        if (currentHealth <= 0)
        {
            GameOverScreen.SetActive(true);
            Time.timeScale = 0;
            SurvivedText.text = "The Young wins!";
        }
    }
     */

}
