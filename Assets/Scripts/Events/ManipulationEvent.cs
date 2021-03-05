using UnityEngine;
using System.Collections;
using UnityEngine.Events;

namespace MicroscopeNamespace.Events
{
  [System.Serializable]
  public class ManipulationEvent<T> : UnityEvent<T>
  {
    public string EventType = "ManipulationEvent";
  }
}
