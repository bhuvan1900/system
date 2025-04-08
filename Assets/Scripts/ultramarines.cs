using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ultramarines : MonoBehaviour
{
    public float umspeed = 1f;
    public float umcircle = 0.2f;
    public float ahrihorizontalcircle = 0.2f;
    public ahriman ahri;
    private Transform ahrimansform;
    public float ysize = 0.2f;

    private void Start()
    {
        if (ahri != null)
        {
            ahrimansform = ahri.transform;
        }
    }

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
        float distancedistance = transform.position.x - ahrimansform.position.x;
        float distancedistance2 = transform.position.y - ahrimansform.position.y;

        if (distancedistance2 < ysize && distancedistance2 > -ysize && distancedistance < umcircle + ahrihorizontalcircle && distancedistance > -(umcircle + ahrihorizontalcircle))
        {
           collisionresult();
        }

    }
    void collisionresult()
    {
        ahri.GameOver();
    }
}
