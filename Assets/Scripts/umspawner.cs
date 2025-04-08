using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class umspawner : MonoBehaviour
{
    public GameObject putumhere;
    public float timer;
    public float timepassedfromlastspawn;
    public ahriman ahri2;


    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        if(timer > timepassedfromlastspawn)
        {
            spawnum();
            timer = 0f;
        }
    }
   void spawnum()
    {
        float randomer = Random.Range(-7f, 7f);
        Vector3 spawnPosition = new Vector3(randomer, transform.position.y, 0f);

        GameObject newum = Instantiate(putumhere, spawnPosition, Quaternion.identity);

        ultramarines um = newum.GetComponent<ultramarines>();
        if (um != null)
        {
            um.ahri = ahri2;   
        }
        Destroy(newum, 5f);
    }
}
