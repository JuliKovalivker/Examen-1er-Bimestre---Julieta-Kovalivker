////Ingresar:
////nombre de alumno
////de qué año es(un número del 1 al 5)
////a qué orientación pertenece(sólo se puede ingresar la inicial 
//en mayúscula de la especialidad: T para TIC, D para Diseño, G para 
//Gestión, M para Medios y H para Humanidades).
////El programa debe cumplir los siguientes requerimientos:
////Mostrar un mensaje de error si el nombre ingresado es una cadena de 
//caracteres vacía y si el año ingresado no está en el rango del 1 al 5. 
////Si se ingresa un valor diferente a las opciones válidas en el campo 
//ingreso de orientación escribir en consola “Solo puede ingresar T, D, G, M o H”. 
////Si el año ingresado no está entre 3 y 5 se debe mostrar el mensaje “Error.Aún 
//estás en el ciclo básico”.
////Si los ingresos de nombre, año y orientación son válidos escribir en consola 
//un mensaje de agradecimiento en el siguiente formato: “Muchas gracias[nombreAlumno]!”
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EJ : MonoBehaviour
{
    public string nombreAlumno = "";
    public int año = 0;
    public string orientacion = "";

    void Start()
    {
        if(nombreAlumno == "" || año < 1 || año > 5)
        {
            Debug.Log("Error. El nombre o el año del alumno no es valido.");
        }
        else if(año < 3 && orientacion != "")
        {
            Debug.Log("Error. Aún estás en el ciclo básico.");
        }
        else if(año > 3 && (orientacion != "T" && orientacion != "D" && orientacion != "G" && orientacion != "M" && orientacion != "H"))
        {
            Debug.Log("Solo puede ingresar T, D, G, M o H");
        }
        else
        {
            Debug.Log("Muchas gracias " + nombreAlumno + "!");
        }
    }

}//class
