using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tankchanger : MonoBehaviour
{
    public SpriteRenderer sr;
   public void mouseenter()
    {
        sr = GetComponent<SpriteRenderer>();
        sr.color = Color.black;
    }
    public void mouseexit()
    {
        
        sr = GetComponent<SpriteRenderer>();
        gameObject.SetActive(true);

    }
    //public void mouseclick()
    //{
    //    sr = GetComponent<SpriteRenderer>();
    //    sr.color = Color.red;
    //}
}
