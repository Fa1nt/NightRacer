using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
    private int currentGear;
    [SerializeField] private Text speedStr;
    [SerializeField] private Text gearStr;
    [SerializeField] private Text nosStr;
    private int speed;
    private int currentNos;
    [SerializeField] private Rigidbody vehicle;

    public void TextChange()
    {
        speedStr.text = speed.ToString() + " km/h";
        gearStr.text = "Gear: " + currentGear.ToString();
        nosStr.text = "Nitro: " + currentNos.ToString();
    }

    private void Update()
    {
        var vel = vehicle.velocity;
        speed = (int) ((float) vel.magnitude * 3.6f);
        currentGear = GameObject.Find("Car").GetComponent<CarController>().gear;
        currentNos = GameObject.Find("Car").GetComponent<CarController>().nitro;
        TextChange();
    }
}
