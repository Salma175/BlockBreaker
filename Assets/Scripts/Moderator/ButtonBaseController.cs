using UnityEngine;
using UnityEngine.UI;

namespace BlockBreaker
{
    [RequireComponent(typeof(Button))]
    public class ButtonBaseController : MonoBehaviour
    {
        [SerializeField]
        private BBEventType _eventType;

        private Button _button;

        void Start()
        {
            _button = GetComponent<Button>();
            _button.onClick.AddListener(() => {
                EventManager.instance.TriggerEvent(_eventType);
            });
        }
    }
}