using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class TestSave : MonoBehaviour
{
    //public TextMeshProUGI intentosText;

    public ExampleData data;
    public const string pathData = "Data/test";
    public const string nameFileData = "ExampleData";

    private void Start()
    {
        var dataFound = SaveLoadSystemData.LoadData<ExampleData>(pathData, nameFileData);
        if (dataFound != null) 
        {
            data = dataFound;
        }
        else 
        {
            ExampleData data = new ExampleData();
            SaveData();
        }
    }

    private void SaveData()
    {
        SaveLoadSystemData.SaveData(data, pathData, nameFileData);
    }
}
