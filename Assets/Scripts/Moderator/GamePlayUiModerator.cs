using System;
using TMPro;
using UnityEngine;

namespace BlockBreaker
{
    public class GamePlayUiModerator : MonoBehaviour
    {
        [SerializeField]
        private TextMeshProUGUI _livesText;
        [SerializeField]
        private TextMeshProUGUI _scoreText;

        [SerializeField]
        private BlockBreakerData _data;

        private void Start()
        {
           
            EventManager.instance.AddEvent(BBEventType.Lives, DisplayLives);
            EventManager.instance.AddEvent(BBEventType.Score, DisplayScore);

            _data.Score = 0;
            _data.Lives = 0;
        }

        private void DisplayLives()
        {
            _livesText.text = _data.Lives.ToString();
        }

        private void DisplayScore()
        {
            _scoreText.text = _data.Score.ToString();
        }
    }
}