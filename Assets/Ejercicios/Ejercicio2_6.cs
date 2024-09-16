using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio2_6 : MonoBehaviour
{
    int vida = 5;
    int moneda = 10;
    int pocion = 15;
    float media;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("vida= " + vida);
        Debug.Log("moneda= " + moneda);
        Debug.Log("pocion= " + pocion);

        media = vida + moneda + pocion;
        media /= 3;
        Debug.Log("media= " + media);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
