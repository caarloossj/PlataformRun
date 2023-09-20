using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScorePotionsText : MonoBehaviour
{
    public void SetScoreText(int score)
    {
        GetComponent<TMP_Text>().text = "POTIONS: " + Mathf.Round(score);
    }
}
