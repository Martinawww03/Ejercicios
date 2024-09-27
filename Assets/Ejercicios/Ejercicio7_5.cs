using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio7_5 : MonoBehaviour
{
    [SerializeField] private int numero2 = 1;
    // Start is called before the first frame update
    void Start()
    {
        int numero = 1;
        while(numero<=numero)
        {
            Debug.Log(numero);
            numero++;
        }

        for (int numero2=1; numero2<=numero; numero++) 
        {
            Debug.Log(numero);

        }
        
    }

    
}
