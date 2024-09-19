using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio3_7 : MonoBehaviour
{
    [SerializeField] private float baseTriangulo;
    [SerializeField] private float alturaTriangulo;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    float AreaTriangulo(float baseTriangulo,float alturaTriangulo)
    {
        float areatriangulo = (baseTriangulo * alturaTriangulo) / 2f;
        return areatriangulo;
        Debug.Log("Area del triangulo: " + areatriangulo);

    }
}
