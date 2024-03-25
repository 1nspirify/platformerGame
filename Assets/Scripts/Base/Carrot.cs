using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Carrot : MonoBehaviour
{
    public Rigidbody Rigidbody;
    public float Speed;
    // Start is called before the first frame update
    void Start()
    {
        Transform playerTransform = FindAnyObjectByType<PlayerMove>().transform;
        Vector3 toPlayer = (playerTransform.position - transform.position).normalized;
        Rigidbody.velocity = toPlayer*Speed;
    }

    
}
