using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CountdownController : MonoBehaviour
{
    public int countdownTime;
    //public Text countdownDisplay;
    public TextMeshProUGUI countdownDisplay;
    public Text timerDisplay;
    private CarController carController;
    private CarController carController2;
    [SerializeField] GameObject car2;

    void Start()
    {
        carController = GetComponent<CarController>();
        carController.enabled = !carController.enabled;
        if (car2 != null)
        {
            carController2 = car2.GetComponent<CarController>();
            carController2.enabled = !carController2.enabled;
        }
        StartCoroutine(CountdownToStart());            
    }

    IEnumerator CountdownToStart()
    {
        while (countdownTime > 0)
        {
            countdownDisplay.text = countdownTime.ToString();
            yield return new WaitForSeconds(1f);
            countdownTime--;
        }
        countdownDisplay.text = "START!";
        carController.enabled = true;
        if (car2 != null)
        {
            carController2.enabled = true;
        }
        yield return new WaitForSeconds(1f);
        countdownDisplay.gameObject.SetActive(false);
        StartCoroutine(CountdownToEnd());
    }

    IEnumerator CountdownToEnd()
    {
        while (true)
        {
            timerDisplay.text = countdownTime.ToString();
            yield return new WaitForSeconds(1f);
            countdownTime++;
        }
    }
}
