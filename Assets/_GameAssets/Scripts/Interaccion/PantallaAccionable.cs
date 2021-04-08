using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PantallaAccionable : Accionable
{
    public Material materialEncendido;
    public override void Accionar()
    {
        GetComponent<MeshRenderer>().material = materialEncendido;
    }

    public override void Desaccionar()
    {
        throw new System.NotImplementedException();
    }

    
}
