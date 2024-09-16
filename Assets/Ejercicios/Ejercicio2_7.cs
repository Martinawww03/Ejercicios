using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio2_7 : MonoBehaviour
{
    int oro = 7;
    int segundos = 100;
    int oroMinuto;
    int oroHora;
    int oroTotal;
    // Start is called before the first frame update
    void Start()
    {
        oroMinuto = oro * segundos;
        oroHora = oroMinuto * 60;
        oroTotal = oroHora * 4;
        Debug.Log("el numero total de  unidades de oro farmeadas en 4h = "+ oroTotal);



    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
