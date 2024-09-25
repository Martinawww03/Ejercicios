using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio5_6 : MonoBehaviour
{
    [SerializeField] int level = 20;
    // Start is called before the first frame update
    void Start()
    {
        if (level * 10 == 0) 
        {
            Debug.Log("ha alcanzado un nivelo múltiplo de 10");
        }
    }

    
}
