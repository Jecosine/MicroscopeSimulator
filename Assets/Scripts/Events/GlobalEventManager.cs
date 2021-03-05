using UnityEngine;
using System.Collections.Generic;
using System;
using UnityEngine.Events;
using UnityEngine.EventSystems;

namespace MicroscopeNamespace.Events
{
  public class GlobalEventManager : MonoBehaviour
  {
    static GlobalEventManager instance = null;
    static Dictionary<string, BasicEvent> eventDict;
    GlobalEventManager() { }

    public static GlobalEventManager GetInstance()
    {
      if (instance != null)
      {
        return instance;
      }
      instance = FindObjectOfType(typeof(GlobalEventManager)) as GlobalEventManager;
      if (instance == null)
      {
        Debug.LogError("At least ONE GlobalEventManager should be activated in scene");
      }
      else
      {
        if (eventDict == null)
        {
          eventDict = new Dictionary<string, BasicEvent>();
        }
        Debug.Log("In manager, returning instance");
        return instance;
      }
      return null;
    }
    public BasicEvent AddEvent(string eventName)
    {
      BasicEvent newEvent = GetEvent(eventName);
      if (newEvent == null)
      {
        newEvent = new BasicEvent();
        eventDict.Add(eventName, newEvent);
      }
      return newEvent;
    }
    public BasicEvent GetEvent(string eventName)
    {
      BasicEvent basicEvent = null;
      eventDict.TryGetValue(eventName, out basicEvent);
      return basicEvent;
    }
    public void BindEvent(string eventName, UnityAction<EventArgs> listener)
    {
      Debug.Log("In manager, binding event");

      BasicEvent tmpEvent = GetEvent(eventName);

      if (tmpEvent != null)
      {
        tmpEvent.AddListener(listener);
      }
      else
      {
        tmpEvent = AddEvent(eventName);
        tmpEvent.AddListener(listener);
      }

    }
    public void UnbindEvent(string eventName)
    {

    }
    public void TriggerEvent(string eventName, EventArgs args)
    {
      BasicEvent basicEvent = GetEvent(eventName);
      Debug.Log("in manager, triggering event");
      if (basicEvent != null)
      {
        Debug.Log("in manager, got event, triggered");
        basicEvent.Invoke(args);
      }
    }
  }
}