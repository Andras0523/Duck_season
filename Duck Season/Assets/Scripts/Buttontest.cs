using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Buttontest : MonoBehaviour
{
    public Animator anim;
    public Animation Reload;
    private void Start()
    {
        anim = gameObject.GetComponent<Animator>();
        Reload = gameObject.GetComponent<Animation>();
    }
    public void Test(string Valami)
    {

        Debug.Log("Lövés");
        anim.StartPlayback(); 
       
    }

}
