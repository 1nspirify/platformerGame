using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pointer : MonoBehaviour
{
    public Transform Aim;
    public Camera PlayerCamera;
    public Transform BodyTransform;

    // Update is called once per frame
    void LateUpdate()
    {
        Debug.Log(Input.mousePosition);
        Ray ray = PlayerCamera.ScreenPointToRay(Input.mousePosition);
        Debug.DrawRay(ray.origin, ray.direction*50, Color.yellow);
        Plane plane = new Plane(-Vector3.forward, Vector3.zero);
        float distance;
        plane.Raycast(ray, out distance);
        Vector3 point = ray.GetPoint(distance);
        Aim.position = point;

        Vector3 toAim = Aim.position - transform.position;
        transform.rotation = Quaternion.LookRotation(toAim);
       
        float angleY = Aim.position.x > transform.position.x ? -45f : 45f;
        BodyTransform.rotation = Quaternion.Lerp(BodyTransform.rotation, Quaternion.Euler(Vector3.up * angleY), 10f * Time.deltaTime);
       
    }
}
