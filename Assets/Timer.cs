using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
    public float duration = 3.0f;
    public float elapsedTime;

    public delegate void OnTimerSignature(string value);
    private OnTimerSignature OnTimer;

    [SerializeField]
    private bool pause = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (pause == false)
        {
            elapsedTime += Time.deltaTime;
            if (elapsedTime > duration)
            {
                elapsedTime -= duration;
                OnTimer.Invoke("test");
            }
        }

    }

    public void StartTimer(float _duration)
    {
        duration = _duration;
        elapsedTime = 0;
        pause = false;
    }
    public void StopTimer()
    {
        duration = 0;
        elapsedTime = 0;
        pause = true;
    }
    public void PauseTimer()
    {
        pause = true;
    }
    public void ResumeTimer()
    {
        pause = false;
    }


}
