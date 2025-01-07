using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameSceneUI : MonoBehaviour
{
    Button btmStart;
    Button btmRetry;

    public void OnButtonClick(GameObject buttonObject)
    {
        string buttonName = buttonObject.name;
        Loader.Load(Loader.Scene.SecondScene);
        Debug.Log("clicked " + buttonName);
    }

    private void InitGame()
    {
        btmStart = GameObject.Find("Start Button").GetComponent<Button>();
        btmRetry = GameObject.Find("Retry Button").GetComponent<Button>();
    }

    private void Awake()
    {
        InitGame();
    }
}