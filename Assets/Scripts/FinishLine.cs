using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FinishLine : MonoBehaviour
{
    [SerializeField] private GameObject finishText1;
    [SerializeField] private GameObject finishText2;
    [SerializeField] private Text time1;
    [SerializeField] private Text time2;
    [SerializeField] private Text timerCount;
    public bool p1finish = false;
    public bool p2finish = false;

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.tag == "Player")
        {
            finishText1.SetActive(true);
            time1.text = timerCount.text;
            // take away control and check if both have finished, if yes then stop the timer
            p1finish = true;
        }
        if (collision.tag == "Player 2")
        {
            finishText2.SetActive(true);
            time2.text = timerCount.text;
            p2finish = true;
        }
    }
}
