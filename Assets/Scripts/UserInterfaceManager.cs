using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UserInterfaceManager : MonoBehaviour
{

    public static UserInterfaceManager Instance;

    public int score;
    public TMP_Text scoreText;


    private void Awake()
    {
        if (Instance == null) Instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void UpdateScore(int points)
    {
        score += points;
        scoreText.text = "Score:" + score;
    }
    
}
