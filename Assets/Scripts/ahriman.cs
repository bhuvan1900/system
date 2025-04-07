using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ahriman : MonoBehaviour
{

    public float speed= 1f;
    public float speed2 = 1f;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x >= -4.2f && transform.position.x <= 12f)
        {
            float a = Input.GetAxis("Horizontal");
            Vector3 movement = new Vector3(a, 0f, 0f) * speed * Time.deltaTime;
            transform.position += movement;
        }
        else
        {
            float a = Input.GetAxis("Horizontal");
            Vector3 movement = new Vector3(a, 0f, 0f) * speed2 * Time.deltaTime;
            transform.position += movement;
        }
            
    }
}
