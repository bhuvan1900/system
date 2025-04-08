using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shardspawner : MonoBehaviour
{
    public GameObject putshardhere;
    public float shardtimer;
    public float shardtimepassedfromlastspawn;
    public ahriman ahri2;
    public int shardcounter = 0;
    public GameObject magnus;
    public int shardstospawn;

  

    // Update is called once per frame
    void Update()
    {
        shardtimer += Time.deltaTime;

        if (shardtimer > shardtimepassedfromlastspawn)
        {
            spawnshard();
            shardtimer = 0f;
        }
    }
    void spawnshard()
    {
        float shardrandomer = Random.Range(-7f, 7f);
        Vector3 shardspawnPosition = new Vector3(shardrandomer, transform.position.y, 0f);

        GameObject newshard = Instantiate(putshardhere, shardspawnPosition, Quaternion.identity);
        shard sh = newshard.GetComponent<shard>();
        
        if (sh != null)
        {
            sh.ahri = ahri2;
            sh.shardspawner = this;
        }
 
        Destroy(sh, 5f);
    }

    public void shardcounterincreaser()
    {
        shardcounter++;
    }

    public int shardcount()
    {
        return shardcounter;
    }

    public void spawnnmagnus()
    {
        if (shardcounter == shardstospawn)
        {
            GameObject prospero = Instantiate(magnus, ahri2.transform.position, Quaternion.identity);
            Destroy(prospero, 2f);
            shardcounter = 0;
        }
    }

}
