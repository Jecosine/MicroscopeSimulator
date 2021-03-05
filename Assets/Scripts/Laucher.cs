using UnityEngine;
using MicroscopeNamespace.Events;
using System;

namespace MicroscopeNamespace
{
  public class Laucher : MonoBehaviour
  {
    GlobalEventManager globalEventManager;
    void Start()
    {
      globalEventManager = GlobalEventManager.GetInstance();
      globalEventManager.BindEvent("test", TestHandler);
    }
    void TestHandler(EventArgs args)
    {
      Debug.Log("event triggered, get args: " + args);
    }
  }
}