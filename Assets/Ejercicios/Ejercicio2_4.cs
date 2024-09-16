using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio2_4 : MonoBehaviour
{
    int vida = 10;

    // Start is called before the first frame update
    void Start()
    {
        vida += 77;
        vida -= 3;
        vida *= 4;
        Debug.Log(vida);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
