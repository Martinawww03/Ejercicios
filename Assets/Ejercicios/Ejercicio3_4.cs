using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio3_4 : MonoBehaviour
{
    [SerializeField] private float exp;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    float CalcularNivel(float exp)
    {
        float calcularNiver = 32 + (9 * exp / 5);
        return calcularNiver;

    }
}
