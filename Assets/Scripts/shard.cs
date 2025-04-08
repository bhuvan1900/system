using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shard : MonoBehaviour
{
    public float shardcircle = 0.2f;
    public float shardcircle2 = 0.2f;
    public float shardx = 0.2f;
    public float shardy = 0.2f;
    public ahriman ahri;
    private Transform ahrimansform;
    public GameObject magnus;
    public shardspawner shardspawner;

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
        if (ahrimansform != null)
        {
            collisioncheck();
        }
    }
    
    void collisioncheck()
    {

        float distancedistance = transform.position.x - ahrimansform.position.x;
        float distancedistance2 = transform.position.y - ahrimansform.position.y;

        if (distancedistance2 < shardy && distancedistance2 > -shardy && distancedistance < shardcircle + shardx && distancedistance > -(shardcircle2 + shardx))
        {
            {
                collisionresult();
            }
        }



    }
         
        
       void collisionresult()
        {
           
            Destroy(gameObject);
            
            if (shardspawner != null)
            {
            shardspawner.shardcounterincreaser();
            shardspawner.spawnnmagnus();
        }
            //image of magnus retrieved from- https://www.artstation.com/artwork/DvN2g9
        }
        
    }
