using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public GameObject prefabProyectil;
    public Transform spawnPoint;

    void Update()
    {
        if (HaApretadoElGatillo())
        {
            Disparar();
        }
    }
    bool HaApretadoElGatillo()
    {
        return OVRInput.GetDown(OVRInput.Button.PrimaryIndexTrigger);
    }
    void Disparar()
    {
        Instantiate(prefabProyectil, spawnPoint.position, spawnPoint.rotation);
    }
}
