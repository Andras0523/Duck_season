using System.Collections;
using System.Timers;
using System.Collections.Generic;
using UnityEngine;

public class weaponlerp : MonoBehaviour
{
    public float maxOffsetX;
    public float maxOffsetY;
    private float xTime=0;
    public float lerpSpeed;
    private Vector3 startPos;

    void Start()
    {
        startPos = transform.localPosition;   
    }

    void Update()
    {
        float mouseX = Mathf.Round(Input.GetAxis("Mouse X"));

        if (mouseX != 0)
        {
            transform.localPosition = Vector3.Lerp(startPos, new Vector3(startPos.x + maxOffsetX, startPos.y, startPos.z), xTime);
            xTime += lerpSpeed * Time.deltaTime;

        }
        else 
        {
            xTime = 0;
            transform.localPosition = startPos;
        }
        Debug.Log(mouseX);
    }
}
