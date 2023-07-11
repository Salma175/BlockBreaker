using UnityEngine;

namespace BlockBreaker
{
    public class GameInitializer : MonoBehaviour
    {
        [SerializeField]
        private BlockBreakerData _data;

        void Awake()
        {
            DontDestroyOnLoad(this.gameObject);
            Initialize();
        }

        private void Initialize()
        {
            new EventManager();
        }
    }
}