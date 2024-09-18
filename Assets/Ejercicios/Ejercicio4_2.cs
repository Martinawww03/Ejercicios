using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio4_2 : MonoBehaviour
{
    string nombre = "Pepe";
    string apellido1 = " Rodriguez";
    string apellido2 = "Jimenez";

    // Start is called before the first frame update
    void Start()
    {
        ConstruirNombre(nombre, apellido1, apellido2);
        
        
    }
    
    void ConstruirNombre(string nombre, string apellido1, string apellido3)
    {
        string construirNombre= nombre+ apellido1 + apellido2;
        
    }

   
}
