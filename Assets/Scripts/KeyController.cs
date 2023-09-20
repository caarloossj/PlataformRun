using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class KeyController : MonoBehaviour
{
    public UnityEvent colletKey;

    private void OnTriggerEnter2D(Collider2D other)
    {
        colletKey.Invoke();
    }
}
