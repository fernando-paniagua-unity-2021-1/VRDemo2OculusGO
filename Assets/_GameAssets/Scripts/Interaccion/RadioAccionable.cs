using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RadioAccionable : Accionable
{
    public GameObject arrow;
    public override void Accionar()
    {
        arrow.transform.rotation = Quaternion.Euler(Vector3.zero);
    }

    public override void Desaccionar()
    {
        throw new System.NotImplementedException();
    }
}
