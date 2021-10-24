using System.Collections;
using System.Timers;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{

    public float Yaxisb;
    public float Xaxisb;
    public float Erzekenyseg = 2f;

    private void Start()
    {
        Cursor.visible = false;
    }

    void Update()
    {
        

        Yaxisb += Input.GetAxis("Mouse X")*Erzekenyseg;
        Xaxisb -= Input.GetAxis("Mouse Y")*Erzekenyseg;
        


        if (Yaxisb > 45f)
        {
            Yaxisb = 44.9999f;
        }
        if (Yaxisb < -35f)
        {
            Yaxisb = -34.9999f;
        }
        if (Xaxisb < -80f)
        {
            Xaxisb = -79.9999f;
        }
        if (Xaxisb > 30f)
        {
            Xaxisb = 29.9999f;
        }
            

        Vector3 rotacio = new Vector3(Xaxisb,Yaxisb);
        transform.eulerAngles = rotacio;
    }
}
