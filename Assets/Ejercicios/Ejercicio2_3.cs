using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio2_3 : MonoBehaviour
{
    int vidas = 10;
    float exp = 5.0f;
    float producto;
    float cociente;
    float resto;
    float doble;
    float triple;

    // Start is called before the first frame update
    void Start()
    {
        producto = vidas * exp;
        cociente = vidas / exp;
        resto = vidas / exp;
        doble = vidas * 2;
        triple = exp * 3;
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
