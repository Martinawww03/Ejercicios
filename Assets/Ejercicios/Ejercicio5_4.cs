using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio5_4 : MonoBehaviour
{
    [SerializeField] int dividendo;
    [SerializeField] int divisor;
    // Start is called before the first frame update
    void Start()
    {
        if (dividendo != 0) 
        {
            int resultado= dividendo/divisor;
            Debug.Log(resultado);

        }
        else
        {
            Debug.Log("Error");        }
    }

    
}
