using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio5_1 : MonoBehaviour
{
    int puntos1;
    int puntos2;

    // Start is called before the first frame update
    void Start()
    {
        if (puntos1==puntos2)
        {
            Debug.Log("la batalla est� re�ida");
        }
        else
        {
            Debug.Log("la batalla no est� re�ida");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
