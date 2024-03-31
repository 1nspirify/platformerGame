using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Carrot : MonoBehaviour
{
    public Rigidbody Rigidbody;
    public float Speed;

    void Start()
    {
        transform.rotation = Quaternion.identity;
        //В Старте будет переопределяться и в итоге поворот будет нулевой
        Transform playerTransform = FindAnyObjectByType<PlayerMove>().transform;
        Vector3 toPlayer = (playerTransform.position - transform.position).normalized;
        Rigidbody.velocity = toPlayer*Speed;
    }

    
}
