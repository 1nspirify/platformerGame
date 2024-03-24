using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class headtarget : MonoBehaviour
{
    public Transform HeadTarget;
   
    void Update()
    {
        transform.position = HeadTarget.position;
    }
}
