using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Exercise01 : MonoBehaviour
{
    public TextMeshProUGUI textTMP;
    private int min = 0;
    private int max = 100;
    public void GenerateRandomNumber()
    {
    textTMP.text = Random.Range(min, max).ToString();
    }
}
