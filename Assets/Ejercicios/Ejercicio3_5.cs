using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio3_5 : MonoBehaviour
{
    [SerializeField] private float radio, pi, areaCircunferencia;
    // Start is called before the first frame update
    void Start()
    {

        
    }

    float Longitud(float pi, float radio)
    {
        float longitud = 2 * pi * radio;
        return longitud;

    }
    float AreaCircunferencia(float pi, float radio)
    {
        float areacircunferencia = pi * radio * 2;
        return areacircunferencia;

    }
}
