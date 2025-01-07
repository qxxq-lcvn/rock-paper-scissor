using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    Image imgYou;       // your selected image (rock, paper scissor)
    Image imgCom;       // computer selected image (rock, paper scissor)

    Text txtYou;        // the score you win
    Text txtCom;        // the score computer win
    Text txtResult;     // the result

    int cntYou = 0;     // number you win
    int cntCom = 0;     // number computer win

    public void CheckResult(int yourResult)
    {
        // algorithm determine the result
        int comResult = UnityEngine.Random.Range(1, 4);
        int k = yourResult - comResult;
        if (k == 0)
        {
            txtResult.text = "Draw.";
        }
        else if (k == 1 || k == -2)
        {
            cntYou++;
            txtResult.text = "You win.";
        }
        else
        {
            cntCom++;
            txtResult.text = "Computer wins.";
        }
        SetResult(yourResult, comResult);    // set game result to UI

        checkWinner();
    }

    void SetResult(int you, int com)
    {
        // change image
        imgYou.sprite = Resources.Load("img_" + you, typeof(Sprite)) as Sprite;
        imgCom.sprite = Resources.Load("img_" + com, typeof(Sprite)) as Sprite;

        // invert image com in x axis
        imgCom.transform.localScale = new Vector3(-1, 1, 1);

        // winning score
        txtYou.text = cntYou.ToString();
        txtCom.text = cntCom.ToString();
    }

    public void checkWinner()
    {
        if (cntYou == 3 && cntCom < 3)
        {
            Loader.Load(Loader.Scene.Winner);
            Debug.Log("You win, " + cntYou);
            Debug.Log("Computer lose, " + cntCom);
        }

        if (cntCom == 3 && cntYou < 3)
        {
            Loader.Load(Loader.Scene.Lose);
            Debug.Log("You lose, " + cntYou);
            Debug.Log("Computer win, " + cntCom);
        }
    }

    public void OnButtonClick(GameObject buttonObject)
    {
        //event when button is clicked
        int you = int.Parse(buttonObject.name.Substring(0, 1));
        Debug.Log("clicked" + you);
        CheckResult(you);
    }

    private void InitGame()
    {
        imgYou = GameObject.Find("ImageUser").GetComponent<Image>();
        imgCom = GameObject.Find("ImageCom").GetComponent<Image>();

        txtYou = GameObject.Find("ScoreUser").GetComponent<Text>();
        txtCom = GameObject.Find("ScoreCom").GetComponent<Text>();
        txtResult = GameObject.Find("TxtResult").GetComponent<Text>();

        //init the text before the game start
        txtResult.text = "Select the button on the right";
    }
    // Start is called before the first frame update
    void Start()
    {
        // init the game
        InitGame();
    }

    // Update is called once per frame
    void Update()
    {
        //exit if press escape key
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
    }
}