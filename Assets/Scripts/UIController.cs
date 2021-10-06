using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
    //public Text speedStr;
    [SerializeField] private Text speedStr;
    private int speed;
    [SerializeField] private Rigidbody vehicle;

    public void TextChange()
    {
        speedStr.text = speed.ToString();
    }

    private void Update()
    {
        var vel = vehicle.velocity;
        speed = (int) (vel.magnitude * (10f/36f));
        TextChange();
    }
}
