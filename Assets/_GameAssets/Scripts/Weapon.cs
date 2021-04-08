using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public GameObject prefabProyectil;
    public Transform spawnPoint;
    private DetectorObjetosVR dovr;
    private void Start()
    {
        dovr = GetComponentInChildren<DetectorObjetosVR>();
    }

    void Update()
    {
        if (HaApretadoElGatillo())
        {
            if (!dovr.HaySeleccion())
            {
                Disparar();
            }
            {
                dovr.AccionarObjeto();
            }
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
