using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    public float Yaxis;
    public float Xaxis;
    public float Erzekenyseg = 2f;

    void Update()
    {
        Yaxis += Input.GetAxis("Mouse X")*Erzekenyseg;
        Xaxis -= Input.GetAxis("Mouse Y")*Erzekenyseg;

        if (Yaxis > 40f)
        {
            Yaxis = 39.9999f;
        }
        if (Yaxis < -27f)
        {
            Yaxis = -26.9999f;
        }
        if (Xaxis < -90f)
        {
            Xaxis = -89.9999f;
        }
        if (Xaxis > 30f)
        {
            Xaxis = 29.9999f;
        }
            

        Vector3 rotacio = new Vector3(Xaxis,Yaxis);
        transform.eulerAngles = rotacio;
    }
}
