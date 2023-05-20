using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damage : MonoBehaviour
{
    public float DamageQuantity;

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player")&& other.GetComponent<Health>())
        {

            other.GetComponent<Health>().HaveDamage(DamageQuantity);
        }
    }
}
