using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GunSwitch : MonoBehaviour
{
    public Image image;

    public Sprite Gun1;
    public Sprite Gun2;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            SetImage1();
        }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            SetImage2();
        }
    }

    public void SetImage1()
    {
        image.sprite = Gun1;
    }

    public void SetImage2()
    {
        image.sprite = Gun2;
    }
}
