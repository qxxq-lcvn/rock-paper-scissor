using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ReturnSceneUI : MonoBehaviour
{
    Button btmReturn;

    public void OnButtonClick()
    {
        string buttonName = btmReturn.name;
        Loader.Load(Loader.Scene.FirstScene);
        Debug.Log("clicked " + buttonName);
    }

    private void InitGame()
    {
        btmReturn = GameObject.Find("Return Button").GetComponent<Button>();
    }

    private void Awake()
    {
        InitGame();
    }
}