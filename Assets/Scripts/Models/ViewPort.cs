using System;
using System.Collections;
using MicroscopeNamespace.Enums;
using MicroscopeNamespace.Events;
using UnityEngine;
namespace MicroscopeNamespace.Models
{
  public class ViewPort : MonoBehaviour, MicroscopeNamespace.Interfaces.IViewPort
  {
    static ViewPort instance = null;
    public static ViewPort GetInstance() {
      if (instance != null) {
        return instance;
      }
      instance = FindObjectOfType(typeof(ViewPort)) as ViewPort;
      if(instance == null) {
        Debug.LogError("There should be ONE viewport");
      }
      return instance;
    }
    public Texture targetTexture;
    public void ZoomScope(FloatArg floatArg)
    {
      
    }
    public void IndensityChange(FloatArg floatArg)
    {

    }
    public void DistanceChange(FloatArg floatArg)
    {

    }
  }
}