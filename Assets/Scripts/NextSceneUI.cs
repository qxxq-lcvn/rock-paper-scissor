using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NextSceneUI : MonoBehaviour
{
    Button btmPlay;
    AudioSource audioSource;

    public void OnButtonClick()
    {
        string buttonName = btmPlay.name;
        Loader.Load(Loader.Scene.ThirdScene);
        audioSource.Play();
        Debug.Log("You've clicked on " + buttonName);
    }

    private void InitGame()
    {
        btmPlay = GameObject.Find("Play Button").GetComponent<Button>();
        audioSource = GameObject.Find("ButtonClick").GetComponent<AudioSource>();
    }
    // Start is called before the first frame update
    void Start()
    {
        // init the game
        InitGame();
    }
}
