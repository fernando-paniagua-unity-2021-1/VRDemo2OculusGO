using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectorObjetosVR : MonoBehaviour
{
    public GameObject prefabSensor;
    public Material materialOff;
    public Material materialOn;
    public Material materialSeleccionable;
    Ray rayo;
    RaycastHit hitInfo;
    GameObject sensor;
    bool hayAccionable = false;
    bool haySeleccionable = false;
    GameObject hijo;
    private void Awake()
    {
        sensor = Instantiate(prefabSensor);
    }
    void Update()
    {
        rayo = new Ray(transform.position, transform.forward);
        bool hayContacto = Physics.Raycast(rayo, out hitInfo);
        if (hayContacto)
        {
            sensor.GetComponent<Renderer>().enabled = true;
            sensor.transform.position = hitInfo.point;
            if (hitInfo.transform.gameObject.GetComponent<Accionable>())
            {
                //Estamos mirando a un "Accionable"
                sensor.GetComponent<Renderer>().material = materialOn;
                hayAccionable = true;
                haySeleccionable = false;            
                LiberarHijo();
            } else if (hitInfo.transform.gameObject.GetComponent<Seleccionable>()) {
                //Estamos mirando a un "Seleccionable"
                sensor.GetComponent<Renderer>().material = materialSeleccionable;
                hayAccionable = false;
                haySeleccionable = true;
                if (hijo != null && hitInfo.transform.gameObject != hijo)
                {
                    LiberarHijo();
                }
            }
            else
            {
                //No estamos mirnado ni a un "Accionable" ni a un "Seleccionable"
                sensor.GetComponent<Renderer>().material = materialOff;
                hayAccionable = false;
                haySeleccionable = false;
                LiberarHijo();
            }
        } else
        {
            sensor.GetComponent<Renderer>().enabled = false;
            hayAccionable = false;
            haySeleccionable = false;
            LiberarHijo();
        }
        if (haySeleccionable && (OVRInput.GetDown(OVRInput.Touch.One) || Input.GetMouseButtonDown(0)))
        {
            hitInfo.transform.SetParent(transform);
            hitInfo.transform.gameObject.GetComponent<Seleccionable>().Selecciona();
            hijo = hitInfo.transform.gameObject;
        } 
        if (OVRInput.GetUp(OVRInput.Touch.One) || Input.GetMouseButtonUp(0))
        {
            hitInfo.transform.SetParent(null);
            hijo = null;
            hitInfo.transform.gameObject.GetComponent<Seleccionable>().Deselecciona();
        }
        if (haySeleccionable && (OVRInput.Get(OVRInput.Touch.One) || Input.GetMouseButton(0)))
        {
            float y;
            if (Application.platform == RuntimePlatform.WindowsEditor)
            {
                y = Input.GetAxis("Vertical");
            } else
            {
                Vector2 primaryTouchpad = OVRInput.Get(OVRInput.Axis2D.PrimaryTouchpad);
                y = primaryTouchpad.y;
            }
            
            if (Mathf.Abs(y) > 0.5f)
            {
                hitInfo.transform.Translate(transform.forward * Time.deltaTime * y);
            }
        }


    }

    private void LiberarHijo()
    {
        if (hijo)
        {
            hijo.transform.SetParent(null);
            hijo.GetComponent<Seleccionable>().Deselecciona();
            hijo = null;
        }
    }

    public bool HaySeleccion()
    {
        return hayAccionable;
    }
    public void AccionarObjeto()
    {
        hitInfo.transform.gameObject.GetComponent<Accionable>().Accionar();
    }
}
