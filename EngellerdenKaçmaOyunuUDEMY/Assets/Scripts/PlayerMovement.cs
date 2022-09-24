using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 0.0f;


    void Update()
    {
        float hiz = speed * Input.GetAxis("Horizontal");//Sadece x düzleminde hareket edecek
        transform.Translate(hiz * Time.deltaTime, 0, 0);//Translate komutu hareket ettirmemizi sağlar

    }
}
