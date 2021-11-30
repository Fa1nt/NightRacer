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
    //private bool finish = false;

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.tag == "Player")
        {
            finishText1.SetActive(true);
            time1 = timerCount;
        }
        if (collision.tag == "Player 2")
        {
            finishText2.SetActive(true);
            time2 = timerCount;
        }
    }
}
