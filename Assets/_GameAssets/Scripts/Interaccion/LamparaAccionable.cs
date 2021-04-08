using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LamparaAccionable : Accionable
{
    public override void Accionar()
    {
        GetComponentInChildren<Light>().enabled = true;
    }

    public override void Desaccionar()
    {
        throw new System.NotImplementedException();
    }
}
