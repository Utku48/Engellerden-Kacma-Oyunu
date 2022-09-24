using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Button : MonoBehaviour
{
    public void On_Click()
    {

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        PlayerHealth.playerhealth = 3;
        KillerRespawn.score = 0;
        Time.timeScale = 1;
    }
}
