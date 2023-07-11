using UnityEngine;
namespace BlockBreaker
{
    [CreateAssetMenu(fileName = "BlockBreakerData", menuName = "ScriptableObjects/BlockBreakerScriptableObject", order = 1)]
    public class BlockBreakerData : ScriptableObject
    {
        private int lives;
        public int Lives { get => lives; set
            {
                lives = value;
                EventManager.instance.TriggerEvent(BBEventType.Lives);
            }
        }

        private int score;
        public int Score
        {
            get => score; set
            {
                score = value;
                EventManager.instance.TriggerEvent(BBEventType.Score);
            }

        }
    }
}