using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LootHeal : MonoBehaviour
{
    // Start is called before the first frame update
    public int HealthValue = 1;

    // Update is called once per frame
    private void OnTriggerEnter(Collider other)
    {
        if (other.attachedRigidbody.GetComponent<PlayerHealth>())
        {
            other.attachedRigidbody.GetComponent<PlayerHealth>().AddHealth(HealthValue);
            Destroy(gameObject);
        }
    }
}
