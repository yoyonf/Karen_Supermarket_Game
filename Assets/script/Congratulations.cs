using System;
using UnityEngine;
using UnityEngine.UI;

public class Congratulations : MonoBehaviour
{

    public GameObject[] objects = new GameObject[12];
    public GameObject winBackground;
    public GameObject objectListUI;
    public bool isWin = false;

    public void DetectWin()
    {
        isWin = true;
        foreach (GameObject obj in objects)
        {
            if (!obj.GetComponent<Toggle>().isOn) isWin = false;
        }

        if (isWin)
        {
            winBackground.SetActive(true);
            objectListUI.SetActive(false);
        }
    }
}
