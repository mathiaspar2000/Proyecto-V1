using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cure : MonoBehaviour
{
    public GameObject HealSound;
    public float CureQuantity;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && other.GetComponent<Health>())
        {
            Instantiate(HealSound);
            other.GetComponent<Health>().GiveHealth(CureQuantity);
            Destroy(gameObject);
        }
    }
}
