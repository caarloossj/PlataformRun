using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;


public class ScorePotionsBehaviour : MonoBehaviour
{
    public int score;
    public UnityEvent<int> OnChangeScore;
    public GameObject[] key;

    private void Start()
    {
        restartScore();
    }

    public void AddScore()
    {
        score += 1;
        OnChangeScore.Invoke(score);
        ActiveKey();
    }

    public void restartScore()
    {
        score = 0;
    }


    public void ActiveKey()
    {
        if (score == 3)
        {
            for(int i = 0; i < 3; i++)
            {
                key[i].SetActive(true);
            }
        }
    }

    public void DesactiveKey()
    {
        for (int i = 0; i < 3; i++)
        {
            key[i].SetActive(false);
        }
    }
}