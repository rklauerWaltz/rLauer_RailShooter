using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    public static GameManager Instance;

    public EnemyBehavior enemies;

    public int score;

    public int stageDifficulty; // does nothing...... yet

    public int enemiesKilled; // how many enemies we have killed
    public int enemiesAlive; 

    public GameObject player;
    public GameObject enemyGroup;
    public Transform playerStart;
    public Transform enemyStart;

    public List<GameObject> enemyList;


    public bool gameActive;
    public int playerLives = 3;

    private void Awake()
    {
        if (Instance == null) Instance = this;

        gameActive = false;
    }

    private void Start()
    {
        foreach (GameObject enemy in enemyList)
        {
            enemiesAlive++;
        }
    }

    public void TriggerChange()
    {
        enemies.ChangeDirection();
    }

    public void UpdateEnemies()
    {
        enemies.AdjustColliderSize();
        enemiesKilled++;
        VictoryCheck();
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(0);
        }
    }


    public void VictoryCheck()
    {
        if(enemiesKilled >= enemiesAlive)
        {
            ResetStage();
        }
    }

    public void GameOverCheck()
    {
        gameActive = false;
        if (playerLives <= 0)
        {
            UserInterfaceManager.Instance.GameOverScreen();
        }
        else
        {
            UserInterfaceManager.Instance.continueGameScreen.SetActive(true);
        }

    }

    public void ResetStage()
    {
        ResetEnemies();
        enemiesKilled = 0;
    }

    public void ResetPlayer()
    {
        player.GetComponent<PlayerHealth>().isAlive = true;
        player.transform.position = playerStart.position;
        gameActive = true;
        if (player.GetComponentInChildren<Animator>() != null)
        {
            player.GetComponentInChildren<Animator>().SetBool("isAlive", true);
        }
    }

    public void ResetEnemies()
    {
        enemyGroup.transform.position = enemyStart.position;
        foreach (GameObject enemy in enemyList)
        {
            enemy.SetActive(true);
        }

    }

    public void ResetGame()
    {
        stageDifficulty++;
        foreach (GameObject enemy in enemyList)
        {
            enemy.SetActive(true);
        }
        enemiesKilled = 0;
        UserInterfaceManager.Instance.score = 0;
        playerLives = 3;
        ResetPlayer();
        ResetEnemies();

        foreach(GameObject enemyDeath in GameObject.FindGameObjectsWithTag("DeathEffect"))
        {
            Destroy(enemyDeath);
        }

    }

}
