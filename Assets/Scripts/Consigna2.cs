using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Consigna2 : MonoBehaviour
    //2. Crear las variables necesarias para ingresar 
    //por Inspector el precio de 3 productos y un monto de dinero disponible.
    //Comunicar si la suma de los mismos supera o no el monto de dinero disponible.
    //Luego indicar cuánto dinero sobra o falta.
{
    public float precio1;
    public float precio2;
    public float precio3;
    public float dinero;
    // Start is called before the first frame update
    void Start()
    {
        float totalprecio = precio1 + precio2 + precio3;
        float Resto = totalprecio - dinero;
        if (totalprecio>dinero)
        {
            Debug.Log("El total a pagar es mayor al monto disponible");
        }
        if (totalprecio<=dinero)
        {
            Debug.Log("El monto es suficiente para pagar el total");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
