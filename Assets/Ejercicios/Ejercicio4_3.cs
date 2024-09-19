using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio4_3 : MonoBehaviour
{
    double cantidad;
    string moneda;

    // Start is called before the first frame update
    void Start()
    {
        Convertir("euro", 1);
    }
    double Convertir(string moneda,double cantidad)
    {
        if (moneda == "euro")
        {
            cantidad = cantidad + (cantidad * 0.1);
            Debug.Log(cantidad);
            return cantidad;

        }
        else if (moneda == "dolar")
        {
            cantidad = cantidad - (cantidad * 0.1);
            Debug.Log(cantidad);
            return cantidad;

        }
        else
        {
            Debug.Log("escribe una moneda valido: euro o dolar.");
            return cantidad;
        }


    }
    
}
