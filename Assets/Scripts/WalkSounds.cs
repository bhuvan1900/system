using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WalkSounds : MonoBehaviour
{
    Animator animator;
    AudioSource audioo;
    public bool playaud = false;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        audioo = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
       
        if (playaud== true)
        {  
            animator.SetTrigger("soundtrigger");
            audioo.Play();
        }
        
    }
    public void FootOnGround()
    {
        Debug.Log("foot on ground");
        playaud = true;
    }
}
