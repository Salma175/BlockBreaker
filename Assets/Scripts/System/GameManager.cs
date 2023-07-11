using System;
using UnityEngine;
namespace BlockBreaker
{
    public class GameManager : MonoBehaviour
    {
        void Start()
        {
            EventManager.instance.AddEvent(BBEventType.Play, Play);
            EventManager.instance.AddEvent(BBEventType.Quit, Quit);
        }

        private void Quit()
        {
#if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
        }

        private void Play()
        {
            //Load Level
            Debug.Log("Play");
        }

        private void OnDestroy()
        {
            EventManager.instance.RemoveEvent(BBEventType.Play, Play);
            EventManager.instance.RemoveEvent(BBEventType.Quit, Quit);
        }
    }
}