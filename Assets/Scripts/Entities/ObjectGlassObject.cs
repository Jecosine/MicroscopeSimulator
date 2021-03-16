using UnityEngine;
using System;
using MicroscopeNamespace.Models;
using MicroscopeNamespace.Events;
// using System.Security.Cryptography;

namespace MicroscopeNamespace.Entities
{
  public class ObjectGlassObject: MonoBehavior
  {
    public Transform instance;
    public ObjectGlass data;
    public GlobalEventManager globalEventManager;
    public void GlassRotation()
    {
      // TODO feedback ui
    }
    void Start()
    {
      globalEventManager = GlobalEventManager.GetInstance();
      data = new ObjectGlass();
    }
    void Update()
    {

    }
    public void SwitchGlass()
    {
      // TODO feedback from ui
    } 
  }
}