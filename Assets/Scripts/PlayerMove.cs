using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{

    public Rigidbody rb;
    public float MoveSpeed;
    public float JumpSpeed;
    public float Friction;
    public bool Grounded;
    public float MaxSpeed;
    public Transform ColliderTransform;
    public float LerpSpeed;
    void Start()
    {

    }
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftControl) || Input.GetKey(KeyCode.S) || !Grounded )
        {
            ColliderTransform.localScale = Vector3.Lerp(ColliderTransform.localScale, new Vector3(1f, 0.5f, 1f), Time.deltaTime * LerpSpeed);
        }
        else
            ColliderTransform.localScale = Vector3.Lerp(ColliderTransform.localScale, Vector3.one, Time.deltaTime * LerpSpeed) ;

        if (Input.GetKeyDown(KeyCode.Space))
        {

            if (Grounded)
            {
                rb.AddForce(0, JumpSpeed, 0, ForceMode.VelocityChange);

            }
        }

    }

    void FixedUpdate()
    {
        float _speedMultiplier = 1f;
        if (Grounded == false)
        {
            _speedMultiplier = 0.2f;
            if (rb.velocity.x > MaxSpeed && Input.GetAxis("Horizontal") > 0)
            {
                _speedMultiplier = 0;
            }
            if (rb.velocity.x < -MaxSpeed && Input.GetAxis("Horizontal") < 0)
            {
                _speedMultiplier = 0;
            }
        }
        
      
        rb.AddForce(Input.GetAxis("Horizontal") * MoveSpeed * _speedMultiplier, 0, 0, ForceMode.VelocityChange);
        if (Grounded)
        {
            rb.AddForce(-rb.velocity.x * Friction, 0, 0, ForceMode.VelocityChange);
        }

    }


    private void OnCollisionStay(Collision collision)
    {
        for (int i = 0; i < collision.contactCount; i++)
        {
            float angle = Vector3.Angle(collision.GetContact(i).normal, Vector3.up);
            if (angle < 45f)
            {
                Grounded = true;
            }
        }
    }
    private void OnCollisionExit(Collision collision)
    {
        Grounded = false;
    }
}
