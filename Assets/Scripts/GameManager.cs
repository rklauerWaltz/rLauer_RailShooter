using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    public EnemyBehavior enemies;


    private void Awake()
    {
        if(Instance == null) Instance = this;
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            ResetScene();
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

}
