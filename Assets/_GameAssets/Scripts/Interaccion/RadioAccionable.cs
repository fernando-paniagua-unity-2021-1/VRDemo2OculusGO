using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RadioAccionable : Accionable
{
    public GameObject arrow;
    Quaternion rotacionInicial;
    private void Awake()
    {
        rotacionInicial = arrow.transform.rotation;
    }
    public override void Accionar()
    {
        if (!activo)
        {
            arrow.transform.rotation = Quaternion.Euler(Vector3.zero);
            activo = true;
        } else
        {
            arrow.transform.rotation = rotacionInicial;
            activo = false;
        }
    }
}
