using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio3_3 : MonoBehaviour
{
    int numero=1;
    int doble;
    int triple;
    // Start is called before the first frame update
    void Start()
    {
        int doble = numero * 2;
        int triple = numero * 3;

        Debug.Log("El doble de " + numero + "es: " + doble);
        Debug.Log("El triple de " + numero + "es: " + triple);

    }

   
}
