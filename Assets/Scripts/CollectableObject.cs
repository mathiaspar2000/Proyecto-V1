using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class CollectableObject : MonoBehaviour
{
    public CollectibleManager collectibleManager;
    public GameObject Sound;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Instantiate(Sound);
            collectibleManager.CollectObject();
            Destroy(gameObject);
        }
    }
}

