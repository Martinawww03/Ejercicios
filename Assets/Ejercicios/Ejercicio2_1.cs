using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio2_1 : MonoBehaviour
{   //2.1
    int edad;
    float altura;
    string nombre;
    int iva;
    float peso;
    bool alumnosRepetidos= false;
    char letra;
    int minutos;
    string matriculaCoche;
    bool mayorDeEdad=false;
    string codigoPostal;
    bool genero=false;
    int numeroDeHijo;
    float tallaCamisa;
    float precio;
    string mensaje;
    int mayorEdad;
    int dias;
    float contador;
    char tallaCamiseta;

    //2.2
    int vidas = 10;
    float exp = 5.0f;
    char cacar = ' ';
    float resultadoSuma;
    float resultadoResta;
    // Start is called before the first frame update

    void Start()
    {
        Debug.Log("Vida = " + vidas);
        Debug.Log("Exp= " + exp);

        resultadoSuma = vidas + exp;
        Debug.Log("resultadoSuma= " + resultadoSuma);

        resultadoResta = exp - vidas;
        Debug.Log("resultadoResta= " + resultadoResta);




    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
