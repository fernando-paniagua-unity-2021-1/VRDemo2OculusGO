using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Accionable : MonoBehaviour
{
    public bool activo = false;
    public abstract void Accionar();
}
