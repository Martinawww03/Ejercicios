using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio3_1 : MonoBehaviour
{
    //3.1
    int vidas = 2;
    int edad = 20;
    string nombre = "martina";
    // Start is called before the first frame update
    void Start()
    {
        
        Debug.Log(vidas);
        Debug.Log(edad);


        //3.3
        Debug.Log("Bienvenido de nuevo " + nombre);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
