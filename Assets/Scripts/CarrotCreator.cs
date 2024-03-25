using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarrotCreator : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject CarrotPrefab;
    public Transform Spawn;

    // Update is called once per frame
    public void Create()
    {
        Instantiate(CarrotPrefab, Spawn.position, Quaternion.identity);

    }
}
