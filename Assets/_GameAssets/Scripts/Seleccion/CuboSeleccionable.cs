using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CuboSeleccionable : Seleccionable
{
    public override void Selecciona()
    {
        estaSeleccionado = true;
        GetComponent<Rigidbody>().isKinematic = true;
    }
    public override void Deselecciona()
    {
        estaSeleccionado = false;
        GetComponent<Rigidbody>().isKinematic = false;
    }

}
