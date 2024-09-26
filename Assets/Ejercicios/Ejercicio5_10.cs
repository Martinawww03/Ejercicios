using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Ejercicio5_10 : MonoBehaviour
{
    int temperatura;
    // Start is called before the first frame update
    void Start()
    {

    }
    void clima()
    {
        if (temperatura <= 10)
        {
            Debug.Log("Tipo de clima es frio");
        }
       //else (10 < temperatura && temperatura <= 20) 
       //{
       //    Debug.Log("Tipo de clima es nublado");
       //}
       //else(20<temperatura&&temperatura<=30)
       //{
       //    Debug.Log("Tipo de clima es caluroso");
       //}
        else if(temperatura>30)
        {
            Debug.Log("Tipo de clima es tropical");
        }
    }
    
       

}
