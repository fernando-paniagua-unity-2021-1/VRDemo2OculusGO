using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EasyPlayer : MonoBehaviour
{
    public float speed;
    float x, y;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        x = Input.GetAxis("Horizontal");
        y = Input.GetAxis("Vertical");
        transform.Translate(x * Time.deltaTime * speed, y * Time.deltaTime * speed, 0);
    }
}
