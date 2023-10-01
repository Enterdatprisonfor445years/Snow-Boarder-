using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    [SerializeField] float ftTorqueAmount = 1f;
    [SerializeField] float ftBoostSpeed = 30f;
    [SerializeField] float ftBaseSpeed = 20f;

    Rigidbody2D rb2d;
    SurfaceEffector2D surfaceEffector2D;
    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        RotatePlayer();
        RespondToBoost();
    }

    void RespondToBoost()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            surfaceEffector2D.speed = ftBoostSpeed;
        }
        else
        {
            surfaceEffector2D.speed = ftBaseSpeed;
        }
    }

    void RotatePlayer()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rb2d.AddTorque(ftTorqueAmount);
            surfaceEffector2D = FindObjectOfType<SurfaceEffector2D>();
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            rb2d.AddTorque(-ftTorqueAmount);
        }
    }
}
