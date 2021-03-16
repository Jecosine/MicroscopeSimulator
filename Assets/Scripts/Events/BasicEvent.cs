using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Events;
using System;

namespace MicroscopeNamespace.Events
{
  public class BasicEvent : UnityEvent<GameObject, EventArgs>
  {

  }
}