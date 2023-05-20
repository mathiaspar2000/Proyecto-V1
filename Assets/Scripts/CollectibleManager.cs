using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CollectibleManager : MonoBehaviour
{
    public int collectibleCount;
    public int targetCount;

    // Llamado cuando se recolecta un objeto
    public void CollectObject()
    {
        collectibleCount++;

        if (collectibleCount >= targetCount)
        {
            ChangeScene();
        }
    }

    // Cambia a la escena deseada
    private void ChangeScene()
    {
        SceneManager.LoadScene("Endgame"); // Reemplaza "NombreDeLaEscena" con el nombre real de tu escena de destino
    }
}

