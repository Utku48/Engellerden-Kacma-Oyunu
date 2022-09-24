using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public static int playerhealth = 3;
    public GameObject Panel;

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("killer"))
        {
            playerhealth--;
        }
        if (playerhealth == 2)
        {
            GameObject.FindGameObjectWithTag("can1").SetActive(false);
        }
        else if (playerhealth == 1)
        {
            GameObject.FindGameObjectWithTag("can2").SetActive(false);
        }
        else if (playerhealth == 0)
        {

            GameObject.FindGameObjectWithTag("can3").SetActive(false);
            Destroy(this.gameObject);
            Time.timeScale = 0;
            Panel.SetActive(true);

        }
    }

}
