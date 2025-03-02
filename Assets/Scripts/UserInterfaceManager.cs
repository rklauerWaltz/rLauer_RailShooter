using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UserInterfaceManager : MonoBehaviour
{

    public static UserInterfaceManager Instance;

    public int score;
    public TMP_Text scoreText;

    //Game Screen Panel References
    public GameObject titleScreen;
    public GameObject gameOverScreen;
    public GameObject continueGameScreen;


    private void Awake()
    {
        if (Instance == null) Instance = this;
        gameOverScreen.SetActive(false);
        titleScreen.SetActive(true);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void Update()
    {
        if(GameManager.Instance.gameActive == false && gameOverScreen.activeSelf == false)
        {
            if (Input.GetKeyDown(KeyCode.Z))
            {
                titleScreen.SetActive(false);
                GameManager.Instance.gameActive = true;
                GameManager.Instance.ResetGame();
            }
        }

        if(gameOverScreen.activeSelf == true)
        {
            if(Input.GetKeyDown(KeyCode.Z))
            {
                gameOverScreen.SetActive(false);
                titleScreen.SetActive(true);
                
            }
        }

        if(continueGameScreen.activeSelf == true)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                GameManager.Instance.ResetPlayer();
                continueGameScreen.SetActive(false);
            }
        }
    }

    public void UpdateScore(int points)
    {
        score += points;
        scoreText.text = "Score:" + score;
    }

    public void GameOverScreen()
    {
        gameOverScreen.SetActive(true);
    }
    
}
