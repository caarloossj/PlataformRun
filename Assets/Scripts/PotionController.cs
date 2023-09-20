using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PotionController : MonoBehaviour
{
    public UnityEvent collectPotionScore;


    private void OnTriggerEnter2D(Collider2D other)
    {
        collectPotionScore.Invoke();
        gameObject.SetActive(false);

    }
}
