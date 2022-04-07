using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ej2 : MonoBehaviour
{

    //Crear las variables necesarias para ingresar por Inspector el precio de 3 productos y 
    //un monto de dinero disponible.Comunicar si la suma de los mismos supera o no 
    //el monto de dinero disponible.Luego indicar cuánto dinero sobra o falta.

    public int precio1;
    public int precio2;
    public int precio3;
    public int monto;

    // Start is called before the first frame update
    void Start()
    {
        int precios;

        precios = precio1 + precio2 + precio3;

        if (precios > monto)
        {
            Debug.Log("Los 3 productos superan el precio del dinero disponible.");
        }

        else if (precios < monto)
        {
            Debug.Log("Los 3 productos no superan el precio del dinero disponible.");
        }

        if (precios > monto)
        {
            int dinerofaltante;
            dinerofaltante = precios - monto;
            Debug.Log("Faltan $" + dinerofaltante);
        }

        else if (precios < monto)
        {
            int dinerosobrante;
            dinerosobrante = monto - precios;
            Debug.Log("Sobran $" + dinerosobrante);
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
