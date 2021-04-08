using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectorObjetosVR : MonoBehaviour
{
    Ray rayo;
    RaycastHit hitInfo;
    void Update()
    {
        rayo = new Ray(transform.position, transform.forward);
        bool hayContacto = Physics.Raycast(rayo, out hitInfo);
        if (hayContacto)
        {
            if (hitInfo.transform.gameObject.GetComponent<Accionable>())
            {
                hitInfo.transform.gameObject.GetComponent<Accionable>().Accionar();
            }
        }
    }
}
