using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    public static GameManager Instance;

    public EnemyBehavior enemies;

    public int score;



    private void Awake()
    {
        if (Instance == null) Instance = this;
    }


    public void TriggerChange()
    {
        enemies.ChangeDirection();
    }

    public void UpdateEnemies()
    {
        enemies.AdjustColliderSize();
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(0);
        }
    }

}
