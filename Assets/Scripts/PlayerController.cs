﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public GameObject player;
    public Rigidbody2D PlayerRigid;
    public float speed;
    public float jumpspeed;
    private bool jumping;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.D)) {
            transform.Translate(speed, 0, 0);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(-speed, 0, 0);
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            PlayerRigid.AddForce(new Vector2(0,jumpspeed));
        }
    }
}