using UnityEngine;

namespace BlockBreaker
{
    public class GameInitializer : MonoBehaviour
    {
        private static GameInitializer _instance;

        void Awake()
        {
            if (_instance == null)
            {
                _instance = this;
                DontDestroyOnLoad(this.gameObject);
            }
            Initialize();
        }

        private void Initialize()
        {
            new EventManager();
        }
    }
}