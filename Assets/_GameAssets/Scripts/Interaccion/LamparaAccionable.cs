using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LamparaAccionable : Accionable
{
    public override void Accionar()
    {
        if (!activo)
        {
            GetComponentInChildren<Light>().enabled = true;
            activo = true;
        } else
        {
            GetComponentInChildren<Light>().enabled = false;
            activo = false;
        }
        
    }
}
