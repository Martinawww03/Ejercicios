using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio2_8 : MonoBehaviour
{
    int vidasTotal = 120;
    int vidaActual;
    int porcentajeVeneno = 3;

    // Start is called before the first frame update
    void Start()
    {
        int dano = vidasTotal * (porcentajeVeneno / 100);
        vidaActual -= dano;

        Debug.Log("El personaje tiene " + vidaActual + " puntos de vida");

    }

  
}
