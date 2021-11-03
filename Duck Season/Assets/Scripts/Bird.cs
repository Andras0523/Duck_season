using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : MonoBehaviour
{
    Rigidbody rb;
    public float ySpeedMax;
    public float forwardSpeedMax;
    public float ySpeedMin;
    public float forwardSpeedMin;
    public float lassulas;
    float forwardSpeed;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Start()
    {
        
        
        forwardSpeed = Random.Range(forwardSpeedMin, forwardSpeedMax);


        rb.velocity = new Vector3(forwardSpeed,Random.Range(ySpeedMin,ySpeedMax));
    }

    private void FixedUpdate()
    {
        if(rb.velocity.y > 0 )
            rb.velocity -= new Vector3(0, lassulas , 0);

    }

    public void Flip()
    {

        StartCoroutine(Delay());
    }
    IEnumerator Delay()
    {
        yield return new WaitForSeconds(0.01f);
        rb.velocity = new Vector3(0, 0, 0);
        rb.velocity = new Vector3(-forwardSpeed, Random.Range(ySpeedMin, ySpeedMax));
        transform.rotation = Quaternion.Euler(0,180,0);
        Debug.Log(transform.eulerAngles);
        

    }
}
