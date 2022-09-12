using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public Text _scoreText;
    public Text _hpText;
    public Text _gameTimerText;

    private int _score;
    public int _hp;
    private float _gameTimer;

    private void Awake()
    {
        instance = this;
    }
     
    void Start()
    {
        ResetScore();
        ResetHP();
        ResetGameTimer();
    }

    private void ResetScore()
    {
        _score = 0;
        _scoreText.text = "Score " + _score.ToString();
    }
    private void ResetHP()
    {
        _hp = 3;
        _hpText.text = "HP " + _hp.ToString();
    }

    public void IncreaseScore()
    {
        _score++;
        _scoreText.text = "Score " + _score.ToString();
    }
    private void ResetGameTimer()
    {
        _gameTimer = 100;
        _gameTimerText.text = "Time " + _gameTimer.ToString();
    }

    public void DecreaseHP()
    {
        _hp--;
        _hpText.text = "HP " + _hp.ToString();
        if (_hp <= 0)
            GameOver();
    }

    public void DecreaseTimer()
    {
        _gameTimer -= Time.deltaTime;
        if (_gameTimer <= 0)
            GameOver();

        _gameTimerText.text = "Time " + _gameTimer.ToString();
    }

    private void Update()
    {
        DecreaseTimer();
    }

    public void GameOver()
    {
        //Destroy(gameObject);
        UnityEditor.EditorApplication.isPaused = true;
    }
}
