using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerLv3 : MonoBehaviour
{
    Image timerImage;
    float timerDuration = 50f; // Duration of the timer in seconds

    // Start is called before the first frame update
    void Start()
    {
        timerImage = GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        timerDuration -= Time.deltaTime;
        timerImage.fillAmount = timerDuration / 50f; // Assuming the timer starts at 10 seconds

        if(timerDuration <= 0)
        {
            timerDuration = 0;
            timerImage.fillAmount = 0;
            // Optionally, you can trigger an event or action when the timer reaches zero
            //Debug.Log("Timer finished!");
        }
    }
}
