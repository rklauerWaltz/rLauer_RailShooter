using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    public EnemyBehavior enemies;

    public bool gameActive;


    private void Awake()
    {
        if(Instance == null) Instance = this;
    }


    // Start is called before the first frame update
    void Start()
    {
        gameActive = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            ResetScene();
        }

        if(Input.GetKeyDown(KeyCode.P))
        {
            UserInterfaceManager.Instance.StartGame();
            gameActive = true;
        }
    }

    public void ResetScene()
    {
        SceneManager.LoadScene(0);
    }

    public void UpdateEnemies()
    {
        enemies.AdjustColliderSize();
    }

    public void GameOver()
    {
        UserInterfaceManager.Instance.gameOverScreen.SetActive(true);
        gameActive = false;
    }
}
