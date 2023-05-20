using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CoinColliders : MonoBehaviour
{
    private int Coin = 0;

    public TextMeshProUGUI coinText; 

    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.tag == "Coin")
        {
            Coin++;
            coinText.text = "Objetos Reciclados: "+ Coin.ToString();
            Debug.Log(Coin);
            Destroy(other.gameObject);
        }
    }
}
