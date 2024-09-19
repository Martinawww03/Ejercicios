using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class Apuntes_While : MonoBehaviour
{ int vidas;

    // Start is called before the first frame update
    void Start()
    {
        while (vidas>0)
        {
            Debug.Log("sigo vivo");
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
