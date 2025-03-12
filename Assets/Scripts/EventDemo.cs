using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class EventDemo : MonoBehaviour
{
    public RectTransform banana;
    public UnityEvent OnTimerFinished;
    public float timerLength = 2f;
    public float t;

    private void Update()
    {
        if (t > timerLength)
        {
            OnTimerFinished.Invoke();
            t = 0;
        }
        //if (t < timerLength)
        //{
        //    t += Time.deltaTime;
            
        //}
        //else
        //{
        //    OnTimerFinished.Invoke();
        //}
    }
    public void MouseJustEntered()
    {
        Debug.Log("Mouse just entered me");
        banana.localScale = Vector3.one * 1.2f;
    }
    public void MouseJustExited()
    {
        Debug.Log("Mouse just left me");
        banana.localScale = Vector3.one;
    }
}
