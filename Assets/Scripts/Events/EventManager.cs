using System;
using System.Collections.Generic;

namespace BlockBreaker
{
    public enum BBEventType
    {
        Play,
        Quit,
        Lives,
        Score
    }
    public class EventManager
    {

        public static EventManager instance;
        Dictionary<BBEventType, Action> gameEvents;

        public EventManager()
        {
            instance = this;
            instance.gameEvents = new Dictionary<BBEventType, Action>();
        }

        public void AddEvent(BBEventType type, Action action)
        {
            if (gameEvents.ContainsKey(type))
            {
                gameEvents[type] += action;
            }
            else
            {
                gameEvents.Add(type, action);
            }
        }
        public void RemoveEvent(BBEventType type, Action action)
        {
            if (gameEvents.ContainsKey(type))
            {
                gameEvents[type] -= action;
            }
        }

        public void TriggerEvent(BBEventType type)
        {
            if (gameEvents.ContainsKey(type))
            {
                gameEvents[type]?.Invoke();
            }
        }

        public void RemoveKey(BBEventType type)
        {
            if (gameEvents.ContainsKey(type))
            {
                gameEvents.Remove(type);
            }
        }
    }
}
