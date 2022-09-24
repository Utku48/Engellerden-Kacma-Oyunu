using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class KillerRespawn : MonoBehaviour
{

    public static int score; //ÖNEMLİ BİR NOT== static methodu sayesinde score bıçak için ve roket için ayrı ayrı +10 puan ekler
    public TextMeshProUGUI scoreValue, bitisYazisi;

    void Update()
    {
        scoreValue.text = score.ToString();
        bitisYazisi.text = "Oyun Bitti ! \n \n Skor: " + score.ToString();//Panel Üzerinde yazan yazı 
    }
    void OnCollisionEnter2D(Collision2D other)
    {

        //Killer Tag'li nesneler bu pozisyonlar arasından Respawn olacak
        float reSpawnX = Random.Range(-5f, 5f);
        float reSpawnY = Random.Range(6.5f, 15f);

        if (other.gameObject.tag == "Line")//Eğer "Line" a çarparsa reSpawn ol
        {
            transform.position = new Vector2(reSpawnX, reSpawnY);
            score += Random.Range(8, 14);//Score'ya 8 ile 14 arasında sayılar ekle
        }
        else if (other.gameObject.tag == "Player")
        {

            transform.position = new Vector2(reSpawnX, reSpawnY);
        }
    }

}
