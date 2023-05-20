using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    public float Salud = 100;
    public float SaludMaxima = 100;
    [Header("Interfaz")]
    public Image HealthBar;
    public Text HealthText;

    [Header("Muerto")]
    public GameObject Muerto;

    void Update()
    {
        ActualizarInterfaz();
    }

    public void ActualizarInterfaz()
    {
        HealthBar.fillAmount = Salud / SaludMaxima;
        HealthText.text = Salud.ToString("f0");
    }

    public void HaveDamage(float damage)
    {
        Salud -= damage;

        if(Salud <= 0)
        {
            Instantiate(Muerto);
            Destroy(gameObject);
        }
    }
    
    public void GiveHealth (float cure)
    {
        Salud += cure;
        if (Salud > SaludMaxima)
        {
            Salud = SaludMaxima;
        }
      
    }
}
