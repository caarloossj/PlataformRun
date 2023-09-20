using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResettableObject : MonoBehaviour
{
    private Vector3 initialPosition;
    private Quaternion initialRotation;

    private void Awake()
    {
        initialPosition = transform.position;
        initialRotation = transform.rotation;

        SceneResetManager.RegisterObject(gameObject);
    }

    public void ResetObject()
    {
        transform.position = initialPosition;
        transform.rotation = initialRotation;
    }
}
