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
    private float speed;
    private int currentNos;
    [SerializeField] private Rigidbody vehicle;

    private Transform needleTransform;
    private const float ZERO_SPEED_ANGLE = 135;
    private const float MAX_SPEED_ANGLE = -135;
    private float maxSpeed;
    [SerializeField] private Transform needle;
    [SerializeField] private Transform nosBar;
    Vector3 barScale;
    public int player = 1;

    public void TextChange()
    {
        speedStr.text = speed.ToString() + " km/h";
        gearStr.text = currentGear.ToString();
        nosStr.text = "Nitro: " + currentNos.ToString();
    }

    private float GetSpeedRotation()
    {
        float totalAngleSize = ZERO_SPEED_ANGLE - MAX_SPEED_ANGLE;
        float normalizedSpeed = speed / maxSpeed;
        return ZERO_SPEED_ANGLE - normalizedSpeed * totalAngleSize;
    }

    private void Awake()
    {
        needleTransform = needle;
        maxSpeed = 260f;
        barScale = nosBar.localScale;
    }

    private void Update()
    {
        var vel = vehicle.velocity;
        speed = (float) vel.magnitude * 3.6f;
        if (player == 1)
        {
            currentGear = GameObject.Find("Car").GetComponent<CarController>().gear;
            currentNos = GameObject.Find("Car").GetComponent<CarController>().nitro;
        }
        else
        {
            currentGear = GameObject.Find("Car (1)").GetComponent<CarController>().gear;
            currentNos = GameObject.Find("Car (1)").GetComponent<CarController>().nitro;
        }
        TextChange();
        if (speed > maxSpeed)
            speed = maxSpeed;
        needleTransform.eulerAngles = new Vector3(0, 0, GetSpeedRotation());

        barScale.x = currentNos / 500f;
        nosBar.localScale = barScale;
    }
}
