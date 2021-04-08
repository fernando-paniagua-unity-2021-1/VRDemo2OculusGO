using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EasyPlayer : MonoBehaviour
{
    public float speed;
    float x, y;
    private DetectorObjetosVR dovr;
    private void Start()
    {
        dovr = GetComponentInChildren<DetectorObjetosVR>();
    }

    // Update is called once per frame
    void Update()
    {
        x = Input.GetAxis("Horizontal");
        y = Input.GetAxis("Vertical");
        transform.Translate(x * Time.deltaTime * speed, y * Time.deltaTime * speed, 0);
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (!dovr.HaySeleccion())
            {
                //Disparar();
            }
            {
                dovr.AccionarObjeto();
            }
        }
    }
}
