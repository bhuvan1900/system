using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ultramarines : MonoBehaviour
{
    public float umspeed = 1f;
    public float umcircle = 1f;
    public ahriman ahri;
   

    // Update is called once per frame
    void Update()
    {
        umattack();
        if(ahri!= null)
        {
            collisioncheck();
        }
    }

    void umattack()
    {
            transform.position += new Vector3(0, -umspeed * Time.deltaTime);

    }

    void collisioncheck()
    {
        float distance = Vector2.Distance(transform.position, ahri.transform.position);
        //took code from here https://docs.unity3d.com/6000.0/Documentation/ScriptReference/Vector3.Distance.html

        if (distance < umcircle + ahri.ahricircle)
        {
            collisionresult();
        }
    }
    void collisionresult()
    {
        ahri.GameOver();
    }
}
