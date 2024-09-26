using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio5_7 : MonoBehaviour
{
    int velocidadJugador1;
    int velocidadJugador2;
    int velocidadJugador3;

    // Start is called before the first frame update
    void Start()
    {
        
    }
    void ordenAtaque()
    {
        if(velocidadJugador1>=velocidadJugador2&&velocidadJugador1>=velocidadJugador3)
        {
            Debug.Log("Jugador 1 con velocidad: " + velocidadJugador1);
            
            if(velocidadJugador2>=velocidadJugador3)
            {
                Debug.Log("Jugador 2 con velocidad: " + velocidadJugador2);
            }
            
        }
    }
    
}
