using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PreFabCreator : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Prefab;
    public Transform Spawn;

    // Update is called once per frame
    public void Create()
    {
        Instantiate(Prefab, Spawn.position, Spawn.rotation);

    }
}
