using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class DoorController : MonoBehaviour
{
    private Animator animDoor;

    public UnityEvent onDoorToch;

    private bool open;

    private BoxCollider2D boxCollider;


    private void Start()
    {
        animDoor = GetComponent<Animator>();

    }

    public void openDoor()
    {
        animDoor.SetBool("open", true);
        open = true;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(open == true)
        {
            onDoorToch.Invoke();
        }
    }

    public void closeDoor()
    {
        open = false;
    }
}


