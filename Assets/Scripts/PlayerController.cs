using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public bool grounded;
    public LayerMask groundLayer;
    private MovementBehavior _mvb;
    private Animator _anim;
    private SpriteRenderer _spr;
    public float jumpSpeed;
    private Vector3 dir;

    public Transform spawn1;
    public Transform spawn2;
    public Transform spawn3;

    // Start is called before the first frame update
    void Start()
    {
        _mvb = GetComponent<MovementBehavior>();
        _anim = GetComponent<Animator>();
        _spr = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        dir = new Vector3(Input.GetAxisRaw("Horizontal"), 0, 0);


        if (Input.GetKeyDown(KeyCode.Space) && grounded == true)
        {
            _mvb.Jump(jumpSpeed);
            _anim.SetTrigger("jump");
        }


        //_spr.flipX = true; //or false;

        //transform.localScale = new Vector3(-1*transform.localScale.x , transform.localScale.y, transform.localScale.z);
        if (dir.x == -1)
        {
            _spr.flipX = true; //or false;
        }
        if (dir.x == 1)
        {
            _spr.flipX = false; //or false;
        }

        if (dir.x != 0)
        {
            _anim.SetInteger("state", 1);
        }

        
        if(!Input.anyKey)
        {
            _mvb.StopMovement();
            _anim.SetInteger("state", 0);
        }

        RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.down, 0.3f, groundLayer);

        if(hit)
        {
            grounded = true;
        }
        else
        {
            grounded = false;
        }
    }

    public void FixedUpdate()
    {
        _mvb.MoveRB(dir);
    }

    public void DamagePlayer()
    {
        _anim.SetTrigger("hurt");
    }

    public void DiePlayer()
    {
        _anim.SetTrigger("die");
    }

    public void PlayerStartPosition()
    {
        gameObject.transform.SetPositionAndRotation(spawn1.transform.position, spawn1.transform.rotation);
    }
    public void ChangePlayerPosition1()
    {
        gameObject.transform.SetPositionAndRotation(spawn2.transform.position, spawn2.transform.rotation);
    }

    public void ChangePlayerPosition2()
    {
        gameObject.transform.SetPositionAndRotation(spawn3.transform.position, spawn3.transform.rotation);
    }

}
