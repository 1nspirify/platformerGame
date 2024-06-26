using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rocket : MonoBehaviour
{
    public float Speed;
    public float RotationSpeed;

    public Transform _playerTransform;
    // Start is called before the first frame update
    void Start()
    {
        _playerTransform = FindObjectOfType<PlayerMove>().transform;
    }

    // Update is called once per frame
    void Update()
    {
        if (_playerTransform != null)
        {
            transform.position += Time.deltaTime * transform.forward * Speed;
            Vector3 toPlayer = _playerTransform.position - transform.position;
            Quaternion targetRotation = Quaternion.LookRotation(toPlayer, Vector3.forward);

            transform.rotation = Quaternion.Lerp(transform.rotation, targetRotation, Time.deltaTime * RotationSpeed);
        }
    }
}
