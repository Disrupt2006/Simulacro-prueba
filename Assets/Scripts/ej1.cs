using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ej1 : MonoBehaviour
{

    //Crea un programa que permita ingresar por Inspector dos valores enteros y responda 
    //si son iguales o no lo son.

    public int num1;
    public int num2;

    // Start is called before the first frame update
    void Start()
    {
        if (num1 == num2)
        {
            Debug.Log("Los dos numeros son iguales.");
        }

        else
        {
            Debug.Log("Los dos numeros son diferentes.");
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
