using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class TimerDisplay : MonoBehaviour
{
   public Text timerText;
   public Timer1 timer;

   private void FixedUpdate()
   {
        if (timer.timerCount > 0 && timer.isStartTimer)
        {
            int min = (int)timer.timerCount / 60;
            int sec = (int)timer.timerCount % 60;

            timerText.text = string.Format("{0:00}:{1:00}", min ,sec);
        }
   }
}
