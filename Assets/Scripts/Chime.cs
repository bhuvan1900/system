using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chime : MonoBehaviour
{
    public Clck clock;

    private void Start()
    {
        clock.OntheHour.AddListener(Chimer);
    }
    public void Chimer(int hour)
    {
        Debug.Log("Chiming" + hour + "o'clock!");

    }

    public void ChimeWithoutArguments()
    {
        Debug.Log("Chiming");
    }

}
