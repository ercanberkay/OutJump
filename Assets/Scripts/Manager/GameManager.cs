using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public bool _isStart;
    public int _starCount;
    int _currentLevelIndex;
    void Start()
    {
        _isStart = false;
        _currentLevelIndex = SceneManager.GetActiveScene().buildIndex;
    }

   
    void Update()
    {
        
    }

  

    public void GameOver()
    {
        SceneManager.LoadScene(0);
    }
}
