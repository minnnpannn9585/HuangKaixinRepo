using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerLv3 : MonoBehaviour
{
    Image timerImage;
    public float timerDuration; // Duration of the timer in seconds
    float currentTime;

    // Start is called before the first frame update
    void Start()
    {
        timerImage = GetComponent<Image>();
        currentTime = timerDuration;
    }

    // Update is called once per frame
    void Update()
    {
        currentTime -= Time.deltaTime;
        timerImage.fillAmount = currentTime / timerDuration;

        if(currentTime <= 0)
        {
            currentTime = 0;
            timerImage.fillAmount = 0;
            // Optionally, you can trigger an event or action when the timer reaches zero
            //Debug.Log("Timer finished!");
        }
    }
}
