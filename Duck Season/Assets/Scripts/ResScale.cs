using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResScale : MonoBehaviour
{

    private void Awake()
    {
        int magas = Screen.height;
        int szeles = Screen.width;
        int magasb = (int)Math.Round(magas*0.7f);
        int szelesb = (int)Math.Round(szeles * 0.7f);
        Debug.Log(szelesb+"|"+ magasb);
        

        
        Screen.SetResolution(szelesb,magasb,true);
    }


}
