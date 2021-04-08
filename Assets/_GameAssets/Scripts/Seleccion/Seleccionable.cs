using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Seleccionable : MonoBehaviour
{
    public bool estaSeleccionado = false;
    public abstract void Selecciona();
    public abstract void Deselecciona();
}
