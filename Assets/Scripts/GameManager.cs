using System;
using UnityEngine;
using UnityEngine.UI;

namespace TopEngineTeam
{
    /*
    Управление таймером, счётчиком очков и hp
    Вывод этих значений на UI
    Условие завершения игры
    */
    public class GameManager : MonoBehaviour
    {
        public static GameManager instance;

        [SerializeField] private Text _scoreText;
        [SerializeField] private Text _hpText;
        [SerializeField] private Text _gameTimerText;
        [SerializeField] private Text _LostText;
        [SerializeField] private float _gameSpeedIncreasedPerTile = 0.5f;

        [SerializeField, Range(1, 100)] private float _gameTimer = 100;
        private int _score;
        private int _hp;
        private void Awake()
        {
            instance = this;
        }
        private void Start()
        {
            ResetScore();
            ResetHP();
            ResetGameTimer();
            _LostText.gameObject.SetActive(false);
        }
        private void Update()
        {
            DecreaseTimer();
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
        private void ResetGameTimer()
        {
            _gameTimerText.text = "Time " + _gameTimer.ToString();
        }
        public void IncreaseScore()
        {
            _score++;
            _scoreText.text = "Score " + _score.ToString();

            IncreaseGameSpeed();
        }
        private void IncreaseGameSpeed()
        {
            Player.currentPlayer.IncreasePlayerSpeed(_gameSpeedIncreasedPerTile);
        }
        public void DecreaseHP()
        {
            _hp--;
            _hpText.text = "HP " + _hp.ToString();
            if (PlayerDied())
                GameOver();
        }
        private bool PlayerDied()
        {
            return (_hp <= 0);
        }
        public void DecreaseTimer()
        {
            _gameTimer -= Time.deltaTime;
            _gameTimerText.text = "Time " + Convert.ToInt32(_gameTimer).ToString();
            if (OutOfTime())
                GameOver();
        }
        private bool OutOfTime()
        {
            return _gameTimer < 0;
        }
        public void GameOver()
        {
  /*          Time.timeScale = 0;
            _LostText.gameObject.SetActive(true);*/
            UnityEditor.EditorApplication.isPaused = true;
            _LostText.gameObject.SetActive(true);
        }
    }
}
