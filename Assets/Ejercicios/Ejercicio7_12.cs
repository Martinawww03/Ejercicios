using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio7_12 : MonoBehaviour
{
    int numero1;
    int numero2;
    int suma;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    int  SumarTodosLosNumeros(int numero1, int numero2)
    {
        for (int i = numero1; i <= numero2; i++)
        {
            suma += i;
        }
        return suma;
    }

}
