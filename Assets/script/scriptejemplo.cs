using UnityEngine;

public class scriptejemplo : MonoBehaviour
{
    public string  nombreDelObjeto = "Texto Cualquiera";
    //Variable de tipo entero
    int miVariableNumerica = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("Hola mundo", gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("EStoy en el update");
        //Aumentar en una unidad
        miVariableNumerica = miVariableNumerica + 1;
        //Mostramos
        Debug.Log(nombreDelObjeto + " en el update " + miVariableNumerica);
    }
   
}


