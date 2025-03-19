using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Clck : MonoBehaviour
{

    public Transform hourHand;
    public Transform minuteHand;
    public float timeAnHourTakes;

    public float t;
    public int hour = 0;

    public UnityEvent<int> OntheHour;

    Coroutine clockIsRunning;
    IEnumerator doingOneHourofMovement;

    // Update is called once per frame
    void Start()
    {
       clockIsRunning = StartCoroutine(MoveTheClock());
    }

    IEnumerator MoveTheClock()
    {
        while (true)
        {
            doingOneHourofMovement = MoveTheClockHandsOneHour();
           yield return StartCoroutine(doingOneHourofMovement);
        }
    } 

    IEnumerator MoveTheClockHandsOneHour()
    {
        t = 0;

        while (t < timeAnHourTakes)
        {
            t += Time.deltaTime;
            minuteHand.Rotate(0, 0, -(360 / timeAnHourTakes) * Time.deltaTime);
            hourHand.Rotate(0, 0, -(30 / timeAnHourTakes) * Time.deltaTime);
            yield return null;
        }
        hour++;
        if (hour== 13)
        {
            hour = 1;
        }
        OntheHour.Invoke(hour);
    }

    public void StopTheClock()
    {
        StopCoroutine(clockIsRunning);
        StopCoroutine(doingOneHourofMovement);
    }

}
