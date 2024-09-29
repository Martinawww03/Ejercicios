using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio7_8 : MonoBehaviour
{
    [SerializeField] private int numero1;
    [SerializeField] private int numero2;
    // Start is called before the first frame update
    void Start()
    {
        for(int numero1 = 0; numero1 < numero2; numero1++)
        {
            if(numero1/2==0)
            {
                Debug.Log(numero1);
            }
        }
    }

    
}
