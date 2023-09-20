using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TimeText : MonoBehaviour
{
    public void SetTimeText(float time)
    {
        GetComponent<TMP_Text>().text = "TIME: " + Mathf.Round(time);
    }
}
