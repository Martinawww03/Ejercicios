using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio4_1 : MonoBehaviour
{
    [SerializeField] float lado = 1, radio = 10, Base = 15, altura = 20, pi = 3.14f;   // Start is called before the first frame updatfe
    void Start()
    {
        
    }

    float AreaCuadrado(float lado)
    {
        float acuadrado = lado * lado;
        return acuadrado;

    }
    float AreaTriangulo(float Base,float altura)
    {
        float atriangulo= Base * altura / 2;
        return atriangulo;
    }
    float AreaCirculo(float radio, float pi)
    {
        float acirculo = radio * 2 * pi;
        return acirculo;
    }
}
