using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    // Start is called before the first frame update
    public Vector3 RotationSpeed;

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(RotationSpeed*Time.deltaTime);
    }
}
