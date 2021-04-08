using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PantallaAccionable : Accionable
{
    public Material materialEncendido;
    public Material materialApagado;
    public override void Accionar()
    {
        if (!activo)
        {
            GetComponent<MeshRenderer>().material = materialEncendido;
            activo = true;
        } else {
            GetComponent<MeshRenderer>().material = materialApagado;
            activo = false;
        }
    }
    
}
