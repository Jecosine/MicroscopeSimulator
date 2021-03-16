using UnityEngine;
using System;
using MicroscopeNamespace.Models;
using MicroscopeNamespace.Events;

namespace MicroscopeNamespace.Entities
{
  public class Eyepiece : MonoBehavior
  {
    public Transform instance;
    public GlobalEventManager globalEventManager;
    public Eyepiece data;
    void Start()
    {
      // TODO initialize data
      data = new Eyepiece();
      globalEventManager = GlobalEventManager.GetInstance();
    }
    public void HighlightObject()
    {
      // TODO hightlight object when selected
    }
    public void DetectRaycast()
    {
      // TODO detect raycast from camera
    }
    void Update()
    {
      // TODO detect raycast
      
    }
    public void SwitchGlass()
    {
      // TODO feedback from ui
    }
  }
}